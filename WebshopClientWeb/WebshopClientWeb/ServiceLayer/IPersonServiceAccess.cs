using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public interface IPersonServiceAccess
    {
        HttpStatusCode CurrentHttpStatusCode { get; set; }

        //Task<List<Customer>?>? GetCustomers();

        Task<Person> GetPersonByEmail(string email);

        Task<Person?> SavePerson(Person savePerson);

    }
}
