using System.Collections.Generic;
using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
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

        [Fact]
        public void TestDeletePerson()
        {
            //Arange
            Person testPerson = new Person()
            { FirstName = "Kira",
              LastName = "Dittmer",
              PhoneNo = "53535173",
              Email = "kiradittmer@ucn.dk",
              //PersonType = "Admin"
            };

            int insertedId = _personAccess.CreatePerson(testPerson);

            //Act
            bool deleteResult = _personAccess.DeletePerson(insertedId);

            //Assert
            Assert.True(deleteResult);
        }

        [Fact]
        public void TestUpdatePerson()
        {
            Person testPerson = new Person()
            {
                FirstName = "Kira",
                LastName = "Dittmer",
                PhoneNo = "53535173",
                Email = "kiradittmer@ucn.dk",
                //PersonType = "Admin"
            };

            int insertedId = (_personAccess.CreatePerson(testPerson));

            //Modify details
            testPerson.PersonId = insertedId;
            testPerson.FirstName = "Ida";
            //testPerson.PersonType = "Employee";

            //Act
            bool updateResult = _personAccess.UpdatePerson(testPerson);

            //Assert
            Assert.True(!updateResult);
        }

        [Fact]
        public void TestGetPersonById()
        {
            //Arrange
            int personIdToRetrieve = 1;

            //Act
            Person retrievedPerson = _personAccess.GetPersonById(personIdToRetrieve);   

            //Assert
            Assert.NotNull(retrievedPerson); //Assures that a person object is retrieved
            Assert.Equal(personIdToRetrieve, retrievedPerson.PersonId); //Ensure correct person is retrieved
        }

    }

}

