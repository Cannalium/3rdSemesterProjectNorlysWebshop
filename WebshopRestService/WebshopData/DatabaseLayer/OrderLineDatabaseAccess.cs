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
    public class OrderLineDatabaseAccess : IOrderLineAccess
    {
        readonly string? _connectionString;

        public OrderLineDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("WebshopConnection");
        }

        public int CreateOrderLine(OrderLine anOrderLine)
        {
            int insertedId = -1;
            string insertString = "INSERT INTO OrderLine(orderLineProdQuantity) OUTPUT INSERTED.ID VALUES (@OrderLineProdQuantity)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand createCommand = new SqlCommand(insertString, con))
            {
                // Prepare SQL
                SqlParameter orderLineProdQuantityParam = new SqlParameter("@OrderLineProdQuantity", anOrderLine.OrderLineProdQuantity);
                createCommand.Parameters.Add(orderLineProdQuantityParam);

                con.Open();

                // Execute save and read generated key (ID)
                insertedId = (int)createCommand.ExecuteScalar();
            }
            return insertedId;
        }

        public bool DeleteOrderLine(int orderLineId)
        {
            bool orderLineDeleted = false;
            string queryString = "DELETE FROM OrderLine WHERE orderLineId = @OrderLineId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand deleteCommand = new SqlCommand(queryString, connection))
            {
                // Prepare SQL
                SqlParameter orderLineIdParam = new SqlParameter("@OrderLineId", orderLineId);
                deleteCommand.Parameters.Add(orderLineIdParam);

                connection.Open();

                // Execute delete
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                // Check if the delete operation was successful
                orderLineDeleted = rowsAffected > 0;
            }

            return orderLineDeleted;
        }

        public List<OrderLine> GetOrderLineAll()
        {
            List<OrderLine> foundOrderLines;
            OrderLine readOrderLine;

            string queryString = "SELECT orderLineId, orderLineProdQuantity FROM OrderLine";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();
                // Execute read
                SqlDataReader orderLineReader = readCommand.ExecuteReader();
                // Collect data
                foundOrderLines = new List<OrderLine>();
                while (orderLineReader.Read())
                {
                    readOrderLine = GetOrderLineFromReader(orderLineReader);
                    foundOrderLines.Add(readOrderLine);
                }
            }
            return foundOrderLines;
        }

        public OrderLine GetOrderLineById(int findOrderLineId)
        {
            OrderLine foundOrderLine;

            string queryString = "SELECT orderLineId, orderLineProdQuantity FROM OrderLine WHERE orderLineId = @OrderLineId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter orderLineIdParam = new SqlParameter("@OrderLineId", findOrderLineId);
                readCommand.Parameters.Add(orderLineIdParam);

                con.Open();
                // Execute read
                SqlDataReader orderLineReader = readCommand.ExecuteReader();
                foundOrderLine = new OrderLine(); // It seems the empty constructor is used here
                while (orderLineReader.Read())
                {
                    foundOrderLine = GetOrderLineFromReader(orderLineReader);
                }
            }
            return foundOrderLine;
        }

        public bool UpdateOrderLine(OrderLine orderLineUpdate)
        {
            bool orderLineUpdated = false;
            string queryString = "UPDATE OrderLine SET orderLineProdQuantity = @OrderLineProdQuantity " +
                                 "WHERE orderLineId = @OrderLineId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand updateCommand = new SqlCommand(queryString, connection))
            {
                // Prepare SQL
                SqlParameter orderLineIdParam = new SqlParameter("@OrderLineId", orderLineUpdate.OrderLineId);
                updateCommand.Parameters.Add(orderLineIdParam);

                SqlParameter orderLineProdQuantityParam = new SqlParameter("@OrderLineProdQuantity", orderLineUpdate.OrderLineProdQuantity);
                updateCommand.Parameters.Add(orderLineProdQuantityParam);

                connection.Open();

                // Execute update
                int rowsAffected = updateCommand.ExecuteNonQuery();

                // Check if the update operation was successful
                orderLineUpdated = rowsAffected > 0;
            }

            return orderLineUpdated;
        }

        private OrderLine GetOrderLineFromReader(SqlDataReader orderLineReader)
        {
            OrderLine foundOrderLine;
            int tempOrderLineId;
            int tempOrderLineProdQuantity;

            // Fetch values
            tempOrderLineId = orderLineReader.GetInt32(orderLineReader.GetOrdinal("orderLineId"));
            tempOrderLineProdQuantity = orderLineReader.GetInt32(orderLineReader.GetOrdinal("orderLineProdQuantity"));

            // Create object
            foundOrderLine = new OrderLine(tempOrderLineId, tempOrderLineProdQuantity);
            return foundOrderLine;
        }
    }

}
