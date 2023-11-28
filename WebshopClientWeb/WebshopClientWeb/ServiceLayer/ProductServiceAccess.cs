using System.Net;

namespace WebshopClientWeb.ServiceLayer
{
    public class ProductServiceAccess
    {
        readonly IServiceConnection _productService;
        readonly String _serviceBaseUrl = "https://localhost:7173/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public ProductServiceAccess()
        {
            _productService = new ServiceConnection(_serviceBaseUrl);
        }
    }
}
