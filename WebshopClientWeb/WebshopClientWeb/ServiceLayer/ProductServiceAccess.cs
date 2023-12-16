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

        // Retrieves a list of all products from the ProductService, handling HTTP status codes and returning an empty list on failure
        public async Task<List<Product>> GetAllProducts()
        {
            _productService.UseUrl = $"{_productService.BaseUrl}api/product";

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

        // Retrieves a product by ID from the ProductService, handling HTTP status codes and returning a default Product object on failure
        public async Task<Product> GetProdById(int prodId)
        {
            Product? productFromService = null;

            try
            {
                _productService.UseUrl = $"{_productService.BaseUrl}api/product/{prodId}";

                HttpResponseMessage serviceResponse = await _productService.CallServiceGet();

                if (serviceResponse.IsSuccessStatusCode)
                {
                    string responseData = await serviceResponse.Content.ReadAsStringAsync();
                    productFromService = JsonConvert.DeserializeObject<Product>(responseData);
                }
                else
                {
                    // Handles other status codes by setting productFromService to a default Product object
                    productFromService = new Product();
                }
                CurrentHttpStatusCode = serviceResponse.StatusCode;
            }
            catch (Exception ex)
            {
                throw;
            }
            return productFromService;
        }
    }
}
 

