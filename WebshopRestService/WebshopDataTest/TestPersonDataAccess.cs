using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using Xunit.Abstractions;

namespace WebshopDataTest
{
    public class TestPersonDataAccess
    {

        private readonly ITestOutputHelper _extraOutput;

        readonly private IPersonAccess _personAccess;
        readonly string _connectionString = "Server=hildur.ucn.dk; Database=DMA-CSD-S221_10463673; User Id=DMA-CSD-S221_10463673; password=Password1!";

        public TestPersonDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            _personAccess = new PersonDatabaseAccess(_connectionString);
        }

        [Fact]
        public void TestGetPersonById()
        {
            // Arrange
            string personEmailToRetrieve = "Test@Test.dk";

            // Act
            Person retrievedPerson = _personAccess.GetPersonByEmail(personEmailToRetrieve);

            // Assert
            Assert.NotNull(retrievedPerson); //Assures that a person object is retrieved
            Assert.Equal(personEmailToRetrieve, retrievedPerson.Email); //Ensure correct person is retrieved
        }
    }
}

