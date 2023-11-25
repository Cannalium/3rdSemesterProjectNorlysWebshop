using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientDesktop.ModelLayer;
using static System.Net.WebRequestMethods;

namespace WebshopClientDesktop.ServiceLayer
{
    public class ProductServiceAccess : IProductAccess
    {
        readonly ServiceConnection _productService;

        //Mangler url samt port number - sat til null for nu.
        readonly String _serviceBaseUrl = "https://localhost:7173/api/products/type";

        public ProductServiceAccess()
        {
            _productService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Product>> GetAllProductsByType(string prodType)
        {
            _productService.UseUrl = $"{_productService.BaseUrl}/{prodType}";

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

        public Task<int> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
