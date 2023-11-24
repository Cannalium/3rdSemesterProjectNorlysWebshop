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

        public async Task<Person> GetPersonByUserId(string userId)
        {
            Person foundPerson = await _PersonAccess.GetPersonByUserId(userId);

            return foundPerson;
        }

        public async Task<Person?> CreatePersonFromUserAccount(string userId, string? email)
        {
            Person? createdPerson = null;

            if (!string.IsNullOrEmpty(userId))
            {
                Person PersonToSave = new Person(email, userId);
                createdPerson = await _PersonAccess.SavePerson(PersonToSave);
            }

            return createdPerson;
        }
    }
}
