using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void TestGetAllProducts()
        {
            // Arrange

            // Act
            List<Product> readProducts = _productAccess.GetProductAll();
            bool productsWereRead = (readProducts.Count > 0);
            // Print additional output
            _extraOutput.WriteLine("Number of products: " + readProducts.Count);

            // Assert
            Assert.True(productsWereRead);
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

            // Acts
            bool deleteResult = _productAccess.DeleteProduct(insertedId);

            // Assert
            Assert.True(deleteResult);
        }

        [Fact]
        public void TestUpdateProduct()
        {
            Product testProduct = new Product()
            {
                ProdName = "Mussemåtte",
                ProdDescription = "Mussemåtte med Norlys logo",
                ProdPrice = 30,
                ProdQuantity = 50,
                ProdType = "Merch",
            };

            int insertedId = (_productAccess.CreateProduct(testProduct));

            // Modify Details
        }
    }
}
