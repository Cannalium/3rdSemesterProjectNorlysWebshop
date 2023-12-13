using Microsoft.Extensions.Configuration;
using WebshopData.DatabaseLayer;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;
using Xunit.Abstractions;

namespace WebshopDataTest
{
    public class TestOrderServiceDataAccess
    {
        private readonly ITestOutputHelper _extraOutput;

        readonly private IOrderAccess _orderAccess;
        readonly private IOrderData _orderServiceAccess;

        readonly private IOrderLineAccess _orderLineAccess;
        readonly private IOrderLineData _orderLineServiceAccess;

        readonly private IPersonAccess _personAccess;
        readonly private IPersonData _personServiceAccess;

        readonly private IProductAccess _productAccess;
        readonly private IProductData _productServiceAccess;

        public TestOrderServiceDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            IConfiguration inConfig = TestConfigHelper.GetIConfigurationRoot();

            _orderAccess = new OrderDatabaseAccess(inConfig);
            _orderServiceAccess = new OrderDataControl(_orderAccess);

            _orderLineAccess = new OrderLineDatabaseAccess(inConfig);
            _orderLineServiceAccess = new OrderLineDataControl(_orderLineAccess);

            _personAccess = new PersonDatabaseAccess(inConfig);
            _personServiceAccess = new PersonDataControl(_personAccess);

            _productAccess = new ProductDatabaseAccess(inConfig);
            _productServiceAccess = new ProductDataControl(_productAccess);

        }

        [Fact]
        public void Given_ExistingOrder_When_GettingOrderById_Then_OrderShouldBeReturned()
        {
            // Arrange
            PersonDTORead personDTO = new PersonDTORead()
            {
                FirstName = "Tdfjdsfdsfhgfsad",
                LastName = "sdfskdfkfgg",
                Email = "Takkkkdsfsdfsdfdfasest@Test.dk",
                PhoneNo = "87812937",
            };

            PersonDTOWrite personDTOWrite = new PersonDTOWrite()
            {
                FirstName = "Tdfjdsfdsfhgfsad",
                LastName = "sdfskdfkfgg",
                Email = "Takkkkdsfsdfsdfdfasest@Test.dk",
                PhoneNo = "87812937",
            };

            int insertedPersonId = _personServiceAccess.Add(personDTOWrite);

            personDTO.PersonId = insertedPersonId;

            ProductDTOWrite productDTO = new ProductDTOWrite()
            {
                ProdName = "TestProduct",
                ProdDescription = "TestDescription",
                ProdPrice = 100,
                ProdQuantity = 1,
                ProdType = "Merch",
            };

            int insertedProdId = _productServiceAccess.Add(productDTO);

            List<OrderLineDTOWrite> orderLineDTOWrite = new List<OrderLineDTOWrite>()
            {
                new OrderLineDTOWrite(insertedProdId, 1)
            };

            OrderDTOWrite orderDTO = new OrderDTOWrite(personDTO, 200, orderLineDTOWrite)
            {
            };

            // Act 
            int insertedOrderId = _orderServiceAccess.Add(orderDTO);
            OrderDTORead? orderById = _orderServiceAccess.Get(insertedOrderId);

            // Assert
            Assert.NotNull(orderById);
            Assert.Equal(insertedOrderId, orderById.OrderId);

            // Clean up - Delete the test product from the database?
            bool deletionResult = _orderServiceAccess.Delete(insertedOrderId);
            bool deletionPersonResult = _personServiceAccess.Delete(insertedPersonId);
            bool deletionProductResult = _productServiceAccess.Delete(insertedProdId);
            Assert.True(deletionResult); // Check if deletion was successful
            Assert.True(deletionPersonResult); // Check if deletion was successful
            Assert.True(deletionProductResult); // Check if deletion was successful

        }

        [Fact]
        public void TestTwoOrderLinesOneProduct()
        {
            // Arrange
            PersonDTORead personDTO = new PersonDTORead()
            {
                FirstName = "Tdjdsjdssad",
                LastName = "sdsdsfgfg",
                Email = "Takkghghast@Test.dk",
                PhoneNo = "87859017",
            };

            PersonDTOWrite personDTOWrite = new PersonDTOWrite()
            {
                FirstName = "Tdjdsjdssad",
                LastName = "sdsdsfgfg",
                Email = "Takkghghast@Test.dk",
                PhoneNo = "87859017",
            };

            int insertedPersonId = _personServiceAccess.Add(personDTOWrite);

            personDTO.PersonId = insertedPersonId;

            ProductDTOWrite productDTO = new ProductDTOWrite()
            {
                ProdName = "TestProduct",
                ProdDescription = "TestDescription",
                ProdPrice = 100,
                ProdQuantity = 1,
                ProdType = "Merch",
            };

            int insertedProdId = _productServiceAccess.Add(productDTO);

            List<OrderLineDTOWrite> orderLineDTOWrite = new List<OrderLineDTOWrite>()
            {
                new OrderLineDTOWrite(insertedProdId, 2)
            };

            OrderDTOWrite orderDTO = new OrderDTOWrite(personDTO, 200, orderLineDTOWrite)
            {
            };

            // Act 
            int insertedOrderId = _orderServiceAccess.Add(orderDTO);
            OrderDTORead? orderById = _orderServiceAccess.Get(insertedOrderId);

            // Assert
            Assert.Null(orderById);

            // Clean up - Delete the test product from the database?
            bool deletionPersonResult = _personServiceAccess.Delete(insertedPersonId);
            bool deletionProductResult = _productServiceAccess.Delete(insertedProdId);
            Assert.True(deletionPersonResult); // Check if deletion was successful
            Assert.True(deletionProductResult); // Check if deletion was successful

        }
    }
}
