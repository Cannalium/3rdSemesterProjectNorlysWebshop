using Newtonsoft.Json;
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

       /* public Task<List<Product>> GetProducts()
        {
            List<Product>? listFromService = null;

            _productService.UseUrl = _productService.BaseUrl;
            _productService.UseUrl += $"api/product/";

        }*/

        public async Task<List<Product>> GetAllProductsByType(string prodType)
        {
            _productService.UseUrl = $"{_productService.BaseUrl}api/products/type/{prodType}";


            HttpResponseMessage serviceResponse = await _productService.CallServiceGet();

            if (serviceResponse.IsSuccessStatusCode)
            {
                string responseData = await serviceResponse.Content.ReadAsStringAsync();
                List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(responseData);

                if (products == null)
                {
                    return new List<Product>();
                }
                return products;
            }
            else
            {
                return new List<Product>();
            }
        }
    }
}
