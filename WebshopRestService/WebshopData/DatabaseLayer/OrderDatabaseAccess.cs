using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public class OrderDatabaseAccess : IOrderAccess
    {
        readonly string? _connectionString;
        public OrderDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("WebshopConnection");
        }

        // For test
        public OrderDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

        public int CreateOrder(Order anOrder)
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
        }

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

            string queryString = "select orderId, orderDate, orderPrice from Order";
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

        public Order GetOrderById(int findOrderId)
        {
            Order foundOrder;

            string queryString = "select orderId, orderDate from Order where orderId = @OrderId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter orderIdParam = new SqlParameter("@OrderId", findOrderId);
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

            // Fetch values
            tempOrderId = orderReader.GetInt32(orderReader.GetOrdinal("orderId"));
            tempOrderDate = orderReader.GetDateTime(orderReader.GetOrdinal("orderDate"));

            // Create object
            foundOrder = new Order(tempOrderId, tempOrderDate);
            return foundOrder;
        }
    }
}
