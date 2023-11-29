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
            _extraOutput.WriteLine("Number of persons: " + readProducts.Count);

            // Assert
            Assert.True(productsWereRead);
        }
    }
}
