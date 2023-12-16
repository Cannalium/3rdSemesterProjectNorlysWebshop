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

                int availableQuantity = (int)checkCmd.ExecuteScalar();

                return availableQuantity >= requestedQuantity;
            }
        }

        // Retrieves all orders from the database and returns a list of Order objects
        public List<Order> GetAllOrders()
        {
            List<Order> foundOrders;
            Order readOrder;

            // Prepare SQL
            string queryString = "select orderId, orderDate, orderPrice, personId_FK from [Order]";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();

                // Execute read
                SqlDataReader orderReader = readCommand.ExecuteReader();

                // Collect data
                foundOrders = new List<Order>();
                while (orderReader.Read())
                {
                    readOrder = GetOrderFromReader(orderReader);
                    foundOrders.Add(readOrder);
                }
            }
            return foundOrders;
        }

        // Retrieves an order from the database based on the provided orderId and returns the corresponding Order object
        public Order GetOrderById(int orderId)
        {
            Order foundOrder;

            string queryString = "select orderId, orderDate, orderPrice, personId_FK from [Order] where orderId = @OrderId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter orderIdParam = new SqlParameter("@OrderId", orderId);
                readCommand.Parameters.Add(orderIdParam);

                con.Open();

                // Execute read
                SqlDataReader orderReader = readCommand.ExecuteReader();
                foundOrder = new Order(); // It seems the empty constructor is used here
                while (orderReader.Read())
                {
                    foundOrder = GetOrderFromReader(orderReader);
                }
            }
            return foundOrder;
        }

        // Updates an order in the database based on the provided Order object and returns true if successful
        public bool UpdateOrder(Order orderToUpdate)
        {
            bool orderUpdated = false;
            string queryString = "UPDATE Order SET orderDate = @OrderDate" +
                                 "WHERE orderId = @OrderId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand updateCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter orderIdParam = new SqlParameter("@OrderId", orderToUpdate.OrderId);
                updateCommand.Parameters.Add(orderIdParam);
                SqlParameter orderDateParam = new SqlParameter("@OrderDate", orderToUpdate.OrderDate);
                updateCommand.Parameters.Add(orderDateParam);

                con.Open();

                // Execute update
                int rowsAffected = updateCommand.ExecuteNonQuery();

                // Check if the update operation was successful
                orderUpdated = rowsAffected > 0;
            }
            return orderUpdated;
        }

        // Deletes an order from the database based on the provided orderId and returns true if successful
        public bool DeleteOrder(int orderId)
        {
            bool orderDeleted = false;
            string queryString = "DELETE FROM Order WHERE orderId = @OrderId";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand deleteCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter orderIdParam = new SqlParameter("@OrderId", orderId);
                deleteCommand.Parameters.Add(orderIdParam);

                con.Open();

                // Execute delete
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                // Check if the delete operation was successful
                orderDeleted = rowsAffected > 0;
            }
            return orderDeleted;
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

            Person relatedPerson = _personDatabaseAccess.GetPersonById(tempPersonId_FK);

            // Create object
            foundOrder = new Order(tempOrderId, tempOrderDate, tempOrderPrice, tempPersonId_FK, relatedPerson);
            return foundOrder;
        }
    }
}
