using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public interface IPersonAccess
    {
        HttpStatusCode CurrentHttpStatusCode { get; set; }

        //Task<List<Customer>?>? GetCustomers();

        Task<Person> GetPersonByUserId(string userId);

        //Task<Customer> SaveCustomerMinimal(Customer newCust);
    }
}
