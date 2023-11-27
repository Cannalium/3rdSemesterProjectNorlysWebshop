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
        readonly String _serviceBaseUrl = "https://localhost:7173/api/products/";

        public ProductServiceAccess()
        {
            _productService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Product>> GetAllProductsByType(string prodType)
        {
            _productService.UseUrl = $"{_productService.BaseUrl}type/{prodType}";

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

        public async Task<int> CreateProduct(Product productToSave)
        {
            int insertedProdId = -1;
            _productService.UseUrl = _productService.BaseUrl;

            try
            {
                string jsonProduct = JsonConvert.SerializeObject(productToSave);
                var httpContent = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                //Call service
                var serviceRespone = await _productService.CallServicePost(httpContent);

                //If succesful 200-299
                if (serviceRespone is not null && serviceRespone.IsSuccessStatusCode)
                {
                    string idString = await serviceRespone.Content.ReadAsStringAsync();
                    bool numOk = Int32.TryParse(idString, out insertedProdId);
                    if (!numOk)
                    {
                        insertedProdId = -2;
                    }
                }
            } catch
            {
                insertedProdId = -2;
            }

            return insertedProdId;
        }

        public async Task<bool> DeleteProduct(int prodId)
        {
            bool isDeleted = false;
            _productService.UseUrl = $"{_productService.BaseUrl}{prodId}";

            try
            {
                // Call service to delete chosen product
                var serviceResponse = await _productService.CallServiceDelete();

                // If successful HTTP status code 200-299
                if (serviceResponse is not null && serviceResponse.IsSuccessStatusCode)
                {
                    isDeleted = true;
                }
            }
            catch
            {
                
                isDeleted = false;
            }

            return isDeleted;
        }
    }
}
