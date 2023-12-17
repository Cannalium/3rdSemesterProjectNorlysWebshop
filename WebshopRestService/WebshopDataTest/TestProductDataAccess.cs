using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using Xunit.Abstractions;

namespace WebshopDataTest
{
    public class TestProductDataAccess
    {
        private readonly ITestOutputHelper _extraOutput;

        readonly private IProductAccess _productAccess;
        readonly string _connectionString = "Server=hildur.ucn.dk; Database=DMA-CSD-S221_10463673; User Id=DMA-CSD-S221_10463673; password=Password1!";

        public TestProductDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            _productAccess = new ProductDatabaseAccess(_connectionString);
        }

        [Fact]
        public void TestGetProductById()
        {
            // Arrange
            Product testProduct = new Product()
            {
                ProdName = "TestProduct",
                ProdDescription = "TestDescription",
                ProdPrice = 30,
                ProdQuantity = 1,
                ProdType = "Merch",
            };

            int insertedId = _productAccess.CreateProduct(testProduct);

            // Act
            Product productById = _productAccess.GetProductById(insertedId);

            // Assert
            Assert.NotNull(productById); // Assures that a product object is retrieved
            Assert.Equal(insertedId, productById.ProdId); // Ensure correct product is retrived

            // Clean up - Delete the test product from the database?
            bool deletionResult = _productAccess.DeleteProductById(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void TestGetAllProducts()
        {
            // Arrange

            // Act
            List<Product> readProducts = _productAccess.GetAllProducts();
            bool productsWereRead = (readProducts.Count > 0);
            // Print additional output
            _extraOutput.WriteLine("Number of products: " + readProducts.Count);

            // Assert
            Assert.True(productsWereRead);
        }

        [Fact]
        public void TestUpdateProduct()
        {
            // Arrange
            Product testProduct = new Product()
            {
                ProdName = "Musemåtte",
                ProdDescription = "Musemåtte med Norlys logo",
                ProdPrice = 30,
                ProdQuantity = 50,
                ProdType = "Merch",
            };

            int insertedId = _productAccess.CreateProduct(testProduct);

            // Modify Details
            testProduct.ProdId = insertedId;
            testProduct.ProdName = "Musemåtte med logo";

            // Act
            bool updateResult = _productAccess.UpdateProduct(testProduct);

            // Assert:
            Assert.True(updateResult);

            // Clean up - Delete the test product from the database?
            bool deletionResult = _productAccess.DeleteProductById(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void TestDeleteProduct()
        {
            //Arrange
            Product testProduct = new Product()
            {
                ProdName = "Kaffekrus",
                ProdDescription = "Kaffekrus med Norlys logo",
                ProdPrice = 30,
                ProdQuantity = 100,
                ProdType = "Merch",
            };

            int insertedId = _productAccess.CreateProduct(testProduct);

            // Act
            bool deleteResult = _productAccess.DeleteProductById(insertedId);

            // Assert
            Assert.True(deleteResult);
        }
    }
}
