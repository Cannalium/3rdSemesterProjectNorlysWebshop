using WebshopClientDesktop.ModelLayer;
using WebshopClientDesktop.ServiceLayer;

namespace PersonServiceClientDesktop.ControlLayer
{
    public class PersonControl
    {

        readonly IPersonAccess _personAccess;

        public PersonControl()
        {
            _personAccess = new PersonServiceAccess();
        }

        public async Task<List<Person>?> GetAllPersons()
        {
            List<Person>? foundPersons = null;
            if (_personAccess != null)
            {
                foundPersons = await _personAccess.GetPersons();
            }
            return foundPersons;
        }

        public async Task<int> CreatePerson(string? firstName, string? lastName, string? phoneNo, string? email)
        {
            Person newPerson = new(firstName, lastName, phoneNo, email);
            int insertedId = await _personAccess.CreatePerson(newPerson);
            return insertedId;
        }
    }
}

