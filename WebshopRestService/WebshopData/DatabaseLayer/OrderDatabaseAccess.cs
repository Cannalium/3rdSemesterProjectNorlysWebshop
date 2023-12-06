using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // For test
        public OrderDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

        public int CreateOrder(Order entity)
        {
            int insertedId = -1;

            TransactionOptions tsOptions = new TransactionOptions();
            tsOptions.IsolationLevel = IsolationLevel.RepeatableRead;

            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, tsOptions))
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    // Insert order and fetch its orderId
                    using (SqlCommand cmdOrder = conn.CreateCommand())
                    {
                        cmdOrder.CommandText = "INSERT INTO [Order] (personId_FK, orderDate, orderPrice) OUTPUT INSERTED.OrderId Values(@personId, @orderDate, @orderPrice)";
                        cmdOrder.Parameters.AddWithValue("personId", entity.Person.PersonId);
                        cmdOrder.Parameters.AddWithValue("orderDate", DateTime.Now);
                        cmdOrder.Parameters.AddWithValue("orderPrice", entity.OrderPrice); //SPØRG LARS MEGET VIGTIGT
                        insertedId = (int)cmdOrder.ExecuteScalar(); // Fetch orderId (from OUTPUT INSERTED.OrderId)
                    }

                    // Insert OrderLines
                    foreach (OrderLine orderLine in entity.OrderLines)
                    {
                        // Insert orderline
                        using (SqlCommand cmdOl = conn.CreateCommand())
                        {
                            cmdOl.CommandText = "INSERT INTO [OrderLine] (prodId_FK, orderId_FK, orderLineProdQuantity) Values(@prodId, @orderId, @orderLineProdQuantity)";
                            cmdOl.Parameters.AddWithValue("prodId", orderLine.ProdId);
                            cmdOl.Parameters.AddWithValue("orderId", insertedId);
                            cmdOl.Parameters.AddWithValue("orderLineProdQuantity", orderLine.OrderLineProdQuantity);
                            cmdOl.ExecuteNonQuery();
                        }

                        // decrement stock
                        using (SqlCommand decrementCmd = conn.CreateCommand())
                        {
                            decrementCmd.CommandText = "UPDATE [Product] SET prodQuantity=prodQuantity-@orderLineProdQuantity WHERE prodId=@prodId";
                            decrementCmd.Parameters.AddWithValue("prodId", orderLine.ProdId);
                            decrementCmd.Parameters.AddWithValue("orderLineProdQuantity", orderLine.OrderLineProdQuantity);
                            decrementCmd.ExecuteNonQuery();
                        }
                    }
                }
                ts.Complete();
            }
            return insertedId;
        }


        /*public int CreateOrder(Order anOrder)
        {
            int insertedId = -1;
            string insertString = "insert into Order(orderDate) OUTPUT INSERTED.ID values(@OrderDate)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {
                // Prepare SQL
                SqlParameter orderDateParam = new SqlParameter("@OrderDate", anOrder.OrderDate);
                CreateCommand.Parameters.Add(orderDateParam);

                con.Open();

                // Execute save and read generated key (ID)
                insertedId = (int)CreateCommand.ExecuteScalar();
            }
            return insertedId;
        }*/

        public bool DeleteOrder(int orderId)
        {
            bool orderDeleted = false;
            string queryString = "DELETE FROM Order WHERE orderId = @OrderId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand deleteCommand = new SqlCommand(queryString, connection))
            {
                // Prepare SQL
                SqlParameter orderIdParam = new SqlParameter("@OrderId", orderId);
                deleteCommand.Parameters.Add(orderIdParam);

                connection.Open();

                // Execute delete
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                // Check if the delete operation was successful
                orderDeleted = rowsAffected > 0;
            }
            return orderDeleted;
        }

        public List<Order> GetOrderAll()
        {
            List<Order> foundOrders;
            Order readOrder;

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

        public bool UpdateOrder(Order orderUpdate)
        {
            bool orderUpdated = false;
            string queryString = "UPDATE Order SET orderDate = @OrderDate" +
                                 "WHERE orderId = @OrderId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand updateCommand = new SqlCommand(queryString, connection))
            {
                // Prepare SQL
                SqlParameter orderIdParam = new SqlParameter("@OrderId", orderUpdate.OrderId);
                updateCommand.Parameters.Add(orderIdParam);

                SqlParameter orderDateParam = new SqlParameter("@OrderDate", orderUpdate.OrderDate);
                updateCommand.Parameters.Add(orderDateParam);

                connection.Open();

                // Execute update
                int rowsAffected = updateCommand.ExecuteNonQuery();

                // Check if the update operation was successful
                orderUpdated = rowsAffected > 0;
            }
            return orderUpdated;
        }

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
