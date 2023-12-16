using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public interface IPersonServiceAccess
    {
        HttpStatusCode CurrentHttpStatusCode { get; set; }
        
        Task<Person> GetPersonByEmail(string email);
    }
}
