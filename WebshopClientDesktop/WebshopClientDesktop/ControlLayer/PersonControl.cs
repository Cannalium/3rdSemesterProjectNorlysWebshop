using PersonServiceClientDesktop.ModelLayer;
using PersonServiceClientDesktop.Servicelayer;
using WebshopClientDesktop.ModelLayer;

namespace PersonServiceClientDesktop.ControlLayer
{
    public class PersonControl
    {

        readonly IPersonAccess _pAccess;

        public PersonControl()
        {
            _pAccess = new PersonServiceAccess();
        }

        public async Task<List<Person>?> GetAllPersons()
        {
            List<Person>? foundPersons = null;
            if (_pAccess != null)
            {
                foundPersons = await _pAccess.GetPersons();
            }
            return foundPersons;
        }

        public async Task<int> SavePerson(string fName, string lName, string mPhone)
        {
            Person newPerson = new(fName, lName, mPhone);
            int insertedId = await _pAccess.SavePerson(newPerson);
            return insertedId;
        }
    }
}

