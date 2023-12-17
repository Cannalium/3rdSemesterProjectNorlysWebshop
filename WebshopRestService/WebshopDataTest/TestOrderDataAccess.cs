using Microsoft.Extensions.Configuration;
using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;

namespace WebshopDataTest
{
    public class TestOrderDataAccess
    {
        private readonly string _testConnectionString = "Server=hildur.ucn.dk; Database=YourDatabaseName; User Id=YourUserId; Password=YourPassword;";
        readonly private IPersonAccess _personAccess;
        public TestOrderDataAccess()
        {
            // Initialize _personAccess here
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _personAccess = new PersonDatabaseAccess(configuration);
        }

        [Fact]
        public void TestCreateOrder()
        {
            // Arrange
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var orderAccess = new OrderDatabaseAccess(configuration);

            // Fetch an existing person from the database using email
            Person existingPerson = _personAccess.GetPersonByEmail("Test@Test.dk"); // Change the email as needed

            var orderToCreate = new Order
            {
                Person = existingPerson, // Use the existing person from the database
                OrderPrice = 485,
                OrderLines = new List<OrderLine>
                {
                    new OrderLine { ProdId = 1, OrderLineProdQuantity = 2 },
                    new OrderLine { ProdId = 2, OrderLineProdQuantity = 1 }
                }
            };

            // Act
            int insertedId = orderAccess.CreateOrder(orderToCreate);

            // Assert
            Assert.NotEqual(-1, insertedId); // Assert that order creation was successful
        }

        [Fact]
        public void TestCreateOrderWithError()
        {
            // Arrange
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var orderAccess = new OrderDatabaseAccess(configuration);

            // Mock an existing person (for example, create a new person instead of fetching from the database)
            Person existingPerson = new Person { /* Set necessary properties */ };

            // Create an order with invalid data that would trigger an error
            var orderToCreate = new Order
            {
                Person = existingPerson,
                OrderPrice = 485,
                OrderLines = new List<OrderLine>
                {
                    // Include a product with an invalid ProdId (e.g., a non-existent ID)
                    new OrderLine { ProdId = -1, OrderLineProdQuantity = 2 },
                    new OrderLine { ProdId = 2, OrderLineProdQuantity = 1 }
                }
            };

            // Act
            int insertedId = orderAccess.CreateOrder(orderToCreate);

            // Assert
            Assert.Equal(-2, insertedId); // Assert that order creation failed (you might need to adjust based on your error handling logic)
        }
    }
}

