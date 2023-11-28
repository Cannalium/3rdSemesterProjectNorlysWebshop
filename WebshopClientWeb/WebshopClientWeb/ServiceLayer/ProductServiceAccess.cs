using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class ProductServiceAccess : IProductServiceAccess
    {
        readonly IServiceConnection _productService;
        readonly String _serviceBaseUrl = "https://localhost:7173/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public ProductServiceAccess()
        {
            _productService = new ServiceConnection(_serviceBaseUrl);
        }

        public Task<List<Product>> GetProducts()
        {
            List<Product>? listFromService = null;

            _productService.UseUrl = _productService.BaseUrl;
            _productService.UseUrl += $"api/product/";


        }
    }
}
