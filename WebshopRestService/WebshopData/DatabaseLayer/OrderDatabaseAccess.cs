using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public class OrderDatabaseAccess : IOrderAccess
    {
        readonly string? _connectionString;
        private PersonDatabaseAccess _personDatabaseAccess;
        public OrderDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("WebshopConnection");
            _personDatabaseAccess = new PersonDatabaseAccess(_connectionString);
        }

        // Constructor for testing purposes
        public OrderDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

        // Transaction for creating an order
        public int CreateOrder(Order orderToCreate)
        {
            int insertedId = -1;
            bool sufficientStock = true;

            TransactionOptions tsOptions = new TransactionOptions();
            tsOptions.IsolationLevel = IsolationLevel.ReadUncommitted;

            // Using a TransactionScope to define the boundaries of a transaction block
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, tsOptions))
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    // Validate product quantities
                    foreach (OrderLine orderLine in orderToCreate.OrderLines)
                    {
                        if (!IsSufficientQuantity(con, orderLine.ProdId, orderLine.OrderLineProdQuantity))
                        {
                            sufficientStock = false;
                            insertedId = -2;
                        }
                    }
                    if (sufficientStock)
                    {
                        // Insert order and fetch its orderId
                        using (SqlCommand cmdOrder = con.CreateCommand())
                        {
                            cmdOrder.CommandText = "INSERT INTO [Order] (personId_FK, orderDate, orderPrice) OUTPUT INSERTED.OrderId Values(@personId, @orderDate, @orderPrice)";
                            cmdOrder.Parameters.AddWithValue("personId", orderToCreate.Person.PersonId);
                            cmdOrder.Parameters.AddWithValue("orderDate", DateTime.Now);
                            cmdOrder.Parameters.AddWithValue("orderPrice", orderToCreate.OrderPrice);

                            // Fetch orderId (from OUTPUT INSERTED.OrderId)
                            insertedId = (int)cmdOrder.ExecuteScalar();
                        }

                        // Insert OrderLines
                        foreach (OrderLine orderLine in orderToCreate.OrderLines)
                        {
                            // Insert orderline
                            using (SqlCommand cmdOl = con.CreateCommand())
                            {
                                cmdOl.CommandText = "INSERT INTO [OrderLine] (prodId_FK, orderId_FK, orderLineProdQuantity) Values(@prodId, @orderId, @orderLineProdQuantity)";
                                cmdOl.Parameters.AddWithValue("prodId", orderLine.ProdId);
                                cmdOl.Parameters.AddWithValue("orderId", insertedId);
                                cmdOl.Parameters.AddWithValue("orderLineProdQuantity", orderLine.OrderLineProdQuantity);
                                cmdOl.ExecuteNonQuery();
                            }

                            // decrement stock
                            try
                            {
                                SqlCommand decrementCmd = con.CreateCommand();

                                decrementCmd.CommandText = "UPDATE [Product] SET prodQuantity=prodQuantity-@orderLineProdQuantity WHERE prodId=@prodId";
                                decrementCmd.Parameters.AddWithValue("prodId", orderLine.ProdId);
                                decrementCmd.Parameters.AddWithValue("orderLineProdQuantity", orderLine.OrderLineProdQuantity);
                                decrementCmd.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                insertedId = -3;
                            }
                        }
                    }
                    ts.Complete();
                }
                return insertedId;
            }
        }

        // Checks if the available quantity of a product in the database is sufficient for the requested quantity
        private bool IsSufficientQuantity(SqlConnection conn, int prodId, int requestedQuantity)
        {
            using (SqlCommand checkCmd = conn.CreateCommand())
            {
                checkCmd.CommandText = "SELECT prodQuantity FROM [Product] WHERE prodId=@prodId";
                checkCmd.Parameters.AddWithValue("prodId", prodId);

                using (SqlDataReader reader = checkCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int availableQuantity = reader.GetInt32(reader.GetOrdinal("prodQuantity"));
                        return availableQuantity >= requestedQuantity;
                    }
                    else
                    {
                        // Handle the case where no data is returned (e.g., product with prodId not found)
                        return false;
                    }
                }
            }
        }

        // Constructs an Order object from the data retrieved by the SqlDataReader
        private Order GetOrderFromReader(SqlDataReader orderReader)
        {
            Order foundOrder;
            int tempOrderId;
            DateTime tempOrderDate;
            Decimal tempOrderPrice;
            int tempPersonId_FK;

            // Fetch values
            tempOrderId = orderReader.GetInt32(orderReader.GetOrdinal("orderId"));
            tempOrderDate = orderReader.GetDateTime(orderReader.GetOrdinal("orderDate"));
            tempOrderPrice = orderReader.GetDecimal(orderReader.GetOrdinal("orderPrice"));
            tempPersonId_FK = orderReader.GetInt32(orderReader.GetOrdinal("personId_FK"));

            // Create object
            foundOrder = new Order(tempOrderId, tempOrderDate, tempOrderPrice, tempPersonId_FK);
            return foundOrder;
        }
    }
}
