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
    public class ProductDatabaseAccess : IProductAccess
    {
        readonly string? _connectionString;
        public ProductDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("WebshopConnection");
        }

        // Constructor for testing purposes
        public ProductDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

        // Creates a new Product in the database with the specified attributes and returns the generated prodId
        public int CreateProduct(Product aProduct)
        {
            int insertedId = -1;
            string insertString = "insert into Product(prodName, prodDescription, prodPrice, prodQuantity, prodType) OUTPUT INSERTED.prodId values(@ProdName, @ProdDescription, @ProdPrice, @ProdQuantity, @ProdType)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {
                // Prepare SQL
                SqlParameter prodNameParam = new("@ProdName", aProduct.ProdName);
                CreateCommand.Parameters.Add(prodNameParam);
                SqlParameter prodDescriptionParam = new("@ProdDescription", aProduct.ProdDescription);
                CreateCommand.Parameters.Add(prodDescriptionParam);
                SqlParameter prodPriceParam = new("@ProdPrice", aProduct.ProdPrice);
                CreateCommand.Parameters.Add(prodPriceParam);
                SqlParameter prodQuantityParam = new("@ProdQuantity", aProduct.ProdQuantity);
                CreateCommand.Parameters.Add(prodQuantityParam);
                SqlParameter prodTypeParam = new("@ProdType", aProduct.ProdType);
                CreateCommand.Parameters.Add(prodTypeParam);

                con.Open();

                // Execute save and read generated key (ID)
                insertedId = (int)CreateCommand.ExecuteScalar();
            }
            return insertedId;
        }

        // Retrieves all products from the database and returns a list of Product objects
        public List<Product> GetProductAll()
        {
            List<Product> foundProducts;
            Product readProd;

            string queryString = "select prodId, prodName, prodDescription, prodPrice, prodQuantity, prodType from Product";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();

                // Execute read
                SqlDataReader prodReader = readCommand.ExecuteReader();

                // Collect data
                foundProducts = new List<Product>();
                while (prodReader.Read())
                {
                    readProd = GetProductFromReader(prodReader);
                    foundProducts.Add(readProd);
                }
            }
            return foundProducts;
        }

        // Retrieves products from the database based on the provided product type and returns a list of Product objects
        public List<Product> GetProductByType(string findProdType)
        {
            List<Product> foundProducts;

            string queryString = "select prodId, prodName, prodDescription, prodPrice, prodQuantity, prodType from Product where prodType = @ProdType";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                //Prepare SQL
                SqlParameter prodTypeParam = new SqlParameter("@ProdType", findProdType);
                readCommand.Parameters.Add(prodTypeParam);

                con.Open();

                //Execute read
                SqlDataReader prodReader = readCommand.ExecuteReader();
                foundProducts = new List<Product>();
                while (prodReader.Read())
                {
                    foundProducts.Add(GetProductFromReader(prodReader));
                }
                return foundProducts;
            }
        }

        // Retrieves a product from the database based on the provided prodId and returns the corresponding Product object
        public Product GetProductById(int findProdId)
        {
            Product foundProd;

            string queryString = "select prodId, prodName, prodDescription, prodPrice, prodQuantity, prodType from Product where prodId = @ProdId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter prodIdParam = new SqlParameter("@ProdId", findProdId);
                readCommand.Parameters.Add(prodIdParam);

                con.Open();

                // Execute read
                SqlDataReader prodReader = readCommand.ExecuteReader();
                foundProd = new Product();
                while (prodReader.Read())
                {
                    foundProd = GetProductFromReader(prodReader);
                }
            }
            return foundProd;
        }

        // Updates a product in the database based on the provided Product object and returns true if successful
        public bool UpdateProduct(Product prodUpdate)
        {
            bool prodUpdated = false;
            string queryString = "UPDATE Product SET prodName = @ProdName, prodDescription = @ProdDescription, " +
                                 "prodPrice = @ProdPrice, prodQuantity = @ProdQuantity, prodType = @ProdType " +
                                 "WHERE prodId = @ProdId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand updateCommand = new SqlCommand(queryString, connection))
            {
                //Prepare SQL
                SqlParameter prodIdParam = new SqlParameter("@ProdId", prodUpdate.ProdId);
                updateCommand.Parameters.Add(prodIdParam);
                SqlParameter prodNameParam = new SqlParameter("@ProdName", prodUpdate.ProdName);
                updateCommand.Parameters.Add(prodNameParam);
                SqlParameter prodDescriptionParam = new SqlParameter("@ProdDescription", prodUpdate.ProdDescription);
                updateCommand.Parameters.Add(prodDescriptionParam);
                SqlParameter prodPriceParam = new SqlParameter("@ProdPrice", prodUpdate.ProdPrice);
                updateCommand.Parameters.Add(prodPriceParam);
                SqlParameter prodQuantityParam = new SqlParameter("@ProdQuantity", prodUpdate.ProdQuantity);
                updateCommand.Parameters.Add(prodQuantityParam);
                SqlParameter prodTypeParam = new SqlParameter("@ProdType", prodUpdate.ProdType);
                updateCommand.Parameters.Add(prodTypeParam);

                connection.Open();

                //Execute update
                int rowsAffected = updateCommand.ExecuteNonQuery();

                //Check if the update operation was succesful
                prodUpdated = rowsAffected > 0;
            }
            return prodUpdated;
        }

        // Deletes a Product from the database based on the provided prodId and returns true if successful
        public bool DeleteProduct(int prodId)
        {
            bool productDeleted = false;
            string queryString = "DELETE FROM Product WHERE prodId = @ProdId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand deleteCommand = new SqlCommand(queryString, connection))
            {
                //Prepare SQL
                SqlParameter prodIdParam = new SqlParameter("@ProdId", prodId);
                deleteCommand.Parameters.Add(prodIdParam);

                connection.Open();

                //Execute delete
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                //Check if the delete operation was succesful
                productDeleted = rowsAffected > 0;
            }
            return productDeleted;
        }

        // Constructs a Product object from the data retrieved by the SqlDataReader
        private Product GetProductFromReader(SqlDataReader prodReader)
        {
            Product foundProd;
            int tempProdId;
            string tempProdName;
            string tempProdDescription;
            decimal tempProdPrice;
            int tempProdQuantity;
            string tempProdType;

            // Fetch values
            tempProdId = prodReader.GetInt32(prodReader.GetOrdinal("prodId"));
            tempProdName = prodReader.GetString(prodReader.GetOrdinal("prodName"));
            tempProdDescription = prodReader.GetString(prodReader.GetOrdinal("prodDescription"));
            tempProdPrice = prodReader.GetDecimal(prodReader.GetOrdinal("prodPrice"));
            tempProdQuantity = prodReader.GetInt32(prodReader.GetOrdinal("prodQuantity"));
            tempProdType = prodReader.GetString(prodReader.GetOrdinal("prodType"));

            // Create object
            foundProd = new Product(tempProdId, tempProdName, tempProdDescription, tempProdPrice, tempProdQuantity, tempProdType);
            return foundProd;
        }
    }
}
