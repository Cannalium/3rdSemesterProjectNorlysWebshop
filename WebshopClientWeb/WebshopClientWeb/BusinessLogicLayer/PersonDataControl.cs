using System.Net;
using WebshopClientWeb.Model;
using WebshopClientWeb.ServiceLayer;

namespace WebshopClientWeb.BusinessLogicLayer
{
    public class PersonDataControl
    {
        readonly IPersonServiceAccess _PersonAccess;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public PersonDataControl()
        {
            _PersonAccess = new PersonServiceAccess();
        }

        // Retrieves a person by email using the PersonAccess service asynchronously
        public async Task<Person> GetPersonByEmail(string email)
        {
            Person foundPerson = await _PersonAccess.GetPersonByEmail(email);

            return foundPerson;
        }
    }
}

