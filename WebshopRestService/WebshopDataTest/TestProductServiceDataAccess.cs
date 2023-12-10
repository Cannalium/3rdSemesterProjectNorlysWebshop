using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;
using Xunit.Abstractions;

namespace WebshopDataTest
{
    public class TestProductServiceDataAccess
    {
        private readonly ITestOutputHelper _extraOutput;
        readonly private IProductAccess _productAccess;
        readonly private IProductData _productServiceAccess;
        private IPersonData _personServiceAccess;

        public TestProductServiceDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            IConfiguration inConfig = TestConfigHelper.GetIConfigurationRoot();
            _productAccess = new ProductDatabaseAccess(inConfig);
            _productServiceAccess = new ProductDataControl(_productAccess);
        }

        [Fact]
        public void Given_ExistingProduct_When_GettingProductById_Then_ProductShouldBeReturned()
        {
            //Arrange
            ProductDTOWrite testProduct = new ProductDTOWrite()
            {
                ProdName = "TestProduct",
                ProdDescription = "TestDescription",
                ProdPrice = 20,
                ProdQuantity = 1,
                ProdType = "Merch",
            };

            int insertedId = _productServiceAccess.Add(testProduct);

            //Act
            ProductDTORead? productById = _productServiceAccess.Get(insertedId); // Retrieve the test product

            //Assert
            Assert.NotNull(productById); // Ensure the returned product is not null
            Assert.Equal("TestProduct", productById.ProdName); // Check specific attributes of the returned product

            // Clean up - Delete the test product from the database?
            bool deletionResult = _productServiceAccess.Delete(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void Given_ProductDTOWrite_When_InsertingIntoProductTable_Then_ProductShouldContainExpectedFields()
        {
            //Arrange
            ProductDTOWrite productDTOWrite = new ProductDTOWrite()
            {
                ProdName = "TestProduct",
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

            // Clean up - Delete the test product from the database?
            bool deletionResult = _productServiceAccess.Delete(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void Given_ExistingProducts_When_RetrievingAllProducts_Then_ReturnsValidProductList()
        {
            //Arrange
            //Act
            List<ProductDTORead> productsDTORead = new List<ProductDTORead>();
            bool productsWereRead = (productsDTORead.Count > 0);
            _extraOutput.WriteLine("Number of products: " + productsDTORead.Count);

            //Assert
            Assert.NotEmpty(productsDTORead);
        }


        [Fact]
        public void Given_ProductDTOWrite_When_UpdatingProduct_Then_ProductShouldContainExpectedFields()
        {
            //Arrange
            ProductDTOWrite productDTOWrite = new ProductDTOWrite()
            {
                ProdName = "TestProduct",
                ProdDescription = "TestDescription",
                ProdPrice = 10,
                ProdQuantity = 10,
                ProdType = "Merch",
            };

            int insertedId = _productServiceAccess.Add(productDTOWrite);

            //Act
            productDTOWrite.ProdId = insertedId;
            productDTOWrite.ProdName = "TestProductUpdated";

            bool updateResult = _productServiceAccess.Put(productDTOWrite);

            //Assert
            Assert.True(updateResult);
            ProductDTORead? updatedProduct = _productServiceAccess.Get(insertedId); // Retrieve the updated product from the service
            Assert.Equal("TestProductUpdated", updatedProduct.ProdName); // Verify the updated fields

            // Clean up - Delete the test product from the database?
            bool deletionResult = _productServiceAccess.Delete(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void Given_ExistingProductId_When_DeletingProduct_Then_DeletionShouldBeSuccessful()
        {
            // Arrange
            ProductDTOWrite testProduct = new ProductDTOWrite()
            {
                ProdName = "TestProduct",
                ProdDescription = "TestDescription",
                ProdPrice = 20,
                ProdQuantity = 1,
                ProdType = "Merch",
            };

            int insertedId = _productServiceAccess.Add(testProduct); // Add the test product

            // Act
            bool deletionResult = _productServiceAccess.Delete(insertedId); // Delete the test product

            // Assert
            Assert.True(deletionResult); // Check if deletion was successful
        }

        // Concurrency test
        //[Fact]
        //public void Given_LimitedTickets_When_TwoOrdersAttemptPurchase_Then_OneSucceedsOneFails()
        //{
        //    // Arrange
        //    PersonDTORead personDTORead = new PersonDTORead()
        //    {
        //        FirstName = "TestFornavn",
        //        LastName = "TestEfternavn",
        //        PhoneNo = "55443322",
        //        Email = "test@test.dk",
        //    };

            //int insertedId = _personServiceAccess.Add(personDTORead);
            //PersonDTORead? person = _personServiceAccess.Get(insertedId);


            ////Arrange
            //OrderDTOWrite orderDTOWrite = new OrderDTOWrite()
            //{

            //}
            //Act
            //Assert

        //}

    }
}
