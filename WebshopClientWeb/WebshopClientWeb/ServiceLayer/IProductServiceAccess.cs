using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class IProductServiceAccess
    {
        HttpStatusCode CurrentHttpStatusCode { get; set; }

        Task<List<Product>> GetProducts;
    }
}
