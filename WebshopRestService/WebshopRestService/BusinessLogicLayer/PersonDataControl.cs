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

        public PersonDTORead? GetPersonByEmail(string email)
        {
            PersonDTORead? foundPersonDTO;
            try
            {
                Person? foundPerson = _personAccess.GetPersonByEmail(email);
                foundPersonDTO = ModelConversion.PersonDTOConversion.FromPerson(foundPerson);
            }
            catch
            {
                foundPersonDTO = null;
            }
            return foundPersonDTO;
        }
    }
}
