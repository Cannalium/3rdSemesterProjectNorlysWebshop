

using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public interface IProductServiceAccess
    {
        HttpStatusCode CurrentHttpStatusCode { get; set; }

        //Task<List<Product>> GetProducts();

        Task<List<Product>> GetAllProductsByType(string prodType);
    }
}
