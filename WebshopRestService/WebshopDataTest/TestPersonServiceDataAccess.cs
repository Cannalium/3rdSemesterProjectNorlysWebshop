using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopData.DatabaseLayer;
using WebshopRestService.BusinessLogicLayer;
using Xunit.Abstractions;
using WebshopRestService.DTOs;
using WebshopModel.ModelLayer;

namespace WebshopDataTest
{
    public class TestPersonServiceDataAccess
    {
        private readonly ITestOutputHelper _extraOutput;
        readonly private IPersonAccess _personAccess;
        readonly private IPersonData _personServiceAccess;

        public TestPersonServiceDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            IConfiguration inConfig = TestConfigHelper.GetIConfigurationRoot();
            _personAccess = new PersonDatabaseAccess(inConfig);
            _personServiceAccess = new PersonDataControl(_personAccess);
        }

        [Fact]
        public void Given_ExistingPerson_When_GettingPersonById_Then_PersonShouldBeReturned()
        {
            // Arrange
            PersonDTOWrite personDTO = new PersonDTOWrite()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Email = "Test@Test.dk",
                PhoneNo = "12345678",
            };

            int insertedId = _personServiceAccess.Add(personDTO);

            // Act 
            PersonDTORead? personById = _personServiceAccess.GetPersonById(insertedId);

            // Assert
            Assert.NotNull(personById); // Ensure the returned product is not null
            Assert.Equal(insertedId, personById.PersonId); // Check specific attributes of the returned product

            // Clean up - Delete the test product from the database?
            bool deletionResult = _personServiceAccess.Delete(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void Given_PersonDTOWrite_When_InsertingIntoPersonTable_Then_PersonShouldContainExpectedFields()
        {
            // Arrange
            PersonDTOWrite personDTO = new PersonDTOWrite()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Email = "Test@Test.dk",
                PhoneNo = "87654321",
            };

            int insertedId = _personServiceAccess.Add(personDTO);

            // Act
            PersonDTORead? person = _personServiceAccess.GetPersonById(insertedId);

            // Assert
            Assert.NotNull(person);
            Assert.Equal(personDTO.FirstName, person.FirstName);
            Assert.Equal(personDTO.LastName, person.LastName);
            Assert.Equal(personDTO.Email, person.Email);
            Assert.Equal(personDTO.PhoneNo, person.PhoneNo);

            // Clean up - Delete the test product from the database?
            bool deletionResult = _personServiceAccess.Delete(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void Given_ExistingProducts_When_RetrievingAllProducts_Then_ReturnsValidProductList()
        {
            // Arrange

            //Act
            List<Person> personsDTORead = _personAccess.GetPersonAll();
            bool personsWereRead = (personsDTORead.Count > 0);
            _extraOutput.WriteLine("Number of persons: " + personsDTORead.Count);

            //Assert
            Assert.True(personsWereRead);
            Assert.NotEmpty(personsDTORead);

        }

        [Fact]
        public void Given_PersonDTOWrite_When_UpdatingPerson_Then_PersonShouldContainExpectedFields()
        {
            //Arrange
            PersonDTOWrite personDTOWrite = new PersonDTOWrite()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Email = "Test@Test.dk",
                PhoneNo = "43218765",
            };

            int insertedId = _personServiceAccess.Add(personDTOWrite);
            // Not sure about this - consult
            PersonDTORead personDTORead = new PersonDTORead();

            // Act
            personDTORead.PersonId = insertedId;
            personDTOWrite.FirstName = "TestFirstNameUpdated";

            bool updateResult = _personServiceAccess.Put(personDTOWrite);

            //Assert
            Assert.True(updateResult);
            PersonDTORead? updatedPerson = _personServiceAccess.GetPersonById(insertedId); // Retrieve the updated product from the service
            Assert.Equal("TestFirstNameUpdated", updatedPerson.FirstName); // Verify the updated fields

            // Clean up - Delete the test product from the database?
            bool deletionResult = _personServiceAccess.Delete(insertedId);
            Assert.True(deletionResult); // Check if deletion was successful
        }

        [Fact]
        public void Given_ExistingPersonId_When_DeletingPerson_Then_ReomvalShouldBeSuccessful()
        {
            // Arrange
            PersonDTOWrite personDTOWrite = new PersonDTOWrite()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Email = "Test@Test.dk",
                PhoneNo = "86754321",
            };

            int insertedId = _personServiceAccess.Add(personDTOWrite);

            // Act
            bool deletionResult = _personServiceAccess.Delete(insertedId); // Delete the test person

            // Assert
            Assert.True(deletionResult); // Check if deletion was successful
        }
    }
}
