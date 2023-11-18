using System.Collections.Generic;
using WebshopData.DatabaseLayer;
using WebshopData.ModelLayer;
using WebshopData.DatabaseLayer;
using Xunit;
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
        public void TestGetPersonAll()
        {
            // Arrange

            // Act
            List<Person> readPersons = _personAccess.GetPersonAll();
            bool personsWereRead = (readPersons.Count > 0);
            // Print additional output
            _extraOutput.WriteLine("Number of persons: " + readPersons.Count);

            // Assert
            Assert.True(personsWereRead);
        }

    }

}

