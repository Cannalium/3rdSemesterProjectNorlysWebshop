using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopData.DatabaseLayer;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;
using Xunit.Abstractions;

namespace WebshopDataTest
{
    public class TestProductServiceDataAccess
    {
        private readonly ITestOutputHelper _extraOutPut;
        readonly private IProductAccess _productAccess;
        readonly private IProductData _productServiceAccess;

        public TestProductServiceDataAccess(ITestOutputHelper output)
        {
            _extraOutPut = output;
            IConfiguration inConfig = TestConfigHelper.GetIConfigurationRoot();
            _productAccess = new ProductDatabaseAccess(inConfig);
            _productServiceAccess = new ProductDataControl(_productAccess);
        }

        [Fact]
        public void Given_ProductDTOWrite_When_InsertingIntoProductTable_Then_ProductShouldContainExpectedFields()
        {
            //Arrange
            ProductDTOWrite productDTOWrite = new ProductDTOWrite()
            {
                ProdName = "Test",
                ProdDescription = "TestDescription",
                ProdPrice = 10,
                ProdQuantity = 10,
                ProdType = "Merch",
            };

            //Act
            int insertedId = _productServiceAccess.Add(productDTOWrite);
            ProductDTORead? product = _productServiceAccess.Get(insertedId);


            //Assert
            Assert.NotNull(product);
            Assert.Equal(productDTOWrite.ProdName, product.ProdName);
            Assert.Equal(productDTOWrite.ProdDescription, product.ProdDescription);
            Assert.Equal(productDTOWrite.ProdPrice, product.ProdPrice);
            Assert.Equal(productDTOWrite.ProdQuantity, product.ProdQuantity);
            Assert.Equal(productDTOWrite.ProdType, product.ProdType);
        }

    }
}
