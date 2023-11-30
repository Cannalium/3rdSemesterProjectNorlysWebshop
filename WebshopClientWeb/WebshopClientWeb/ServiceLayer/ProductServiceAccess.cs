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
            _productService.UseUrl = $"{_productService.BaseUrl}api/product/type/{prodType}";

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
                    // Handle other status codes if needed
                    // Set productFromService to a default Product object
                    productFromService = new Product();
                }

                CurrentHttpStatusCode = serviceResponse.StatusCode;
            }
            catch (Exception ex)
            {
                // Log the exception details (You can use a logging library like Serilog, NLog, etc.)
                // Example: logger.LogError(ex, "An error occurred while getting a product by ID");

                // Optionally, rethrow the exception if needed
                throw;
            }

            return productFromService;
        }

        // Other methods (GetAllProductsByType, GetAllProducts) remain unchanged
    }
}
 

