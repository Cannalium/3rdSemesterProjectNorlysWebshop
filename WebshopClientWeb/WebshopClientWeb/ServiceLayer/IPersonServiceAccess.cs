using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public interface IPersonServiceAccess
    {
        HttpStatusCode CurrentHttpStatusCode { get; set; }

        //Task<List<Customer>?>? GetCustomers();

        Task<Person> GetPersonByUserId(string userId);
        Task<Person?> SavePerson(Person savePerson);

    }
}
