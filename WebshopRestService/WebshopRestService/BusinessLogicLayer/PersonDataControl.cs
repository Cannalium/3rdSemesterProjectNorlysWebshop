using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public class PersonDataControl : IPersonData
    {
        private readonly IPersonAccess _personAccess;

        public PersonDataControl(IConfiguration configuration)
        {
            _personAccess = new PersonDatabaseAccess(configuration);
        }

            public int Add(PersonDTO personToAdd)
        {
            int insertedId = 0;
            try
            {
                Person? foundPerson = ModelConversion.PersonDTOConversion.ToPerson(personToAdd);
                if (foundPerson != null)
                {
                    insertedId = _personAccess.CreatePerson(foundPerson);
                }
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int personId)
        {
            try
            {
                bool deletionSuccessful = _personAccess.DeletePerson(personId);
                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public PersonDTO? GetPersonById(int personId)
        {
            PersonDTO? foundPersonDTO;
            try
            {
                Person? foundPerson = _personAccess.GetPersonById(personId);
                foundPersonDTO = ModelConversion.PersonDTOConversion.FromPerson(foundPerson);
            }
            catch
            {
                foundPersonDTO = null;
            }
            return foundPersonDTO;
        }

        public List<PersonDTO>? Get()
        {
            List<PersonDTO>? foundDTOs;
            try
            {
                List<Person>? foundPersons = _personAccess.GetPersonAll();
                foundDTOs = ModelConversion.PersonDTOConversion.FromPersonCollection(foundPersons);
            }
            catch
            {
                foundDTOs = null;
            }
            return foundDTOs;
        }

        public bool Put(PersonDTO personToUpdate)
        {
            try
            {
                Person? updatedPerson = ModelConversion.PersonDTOConversion.ToPerson(personToUpdate);

                if (updatedPerson != null)
                {
                    bool updateSuccessful = _personAccess.UpdatePerson(updatedPerson);
                    return updateSuccessful;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public PersonDTO? GetPersonByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
