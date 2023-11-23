using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.ServiceLayer
{
    public class ProductServiceAccess : IProductAccess
    {
        readonly ServiceConnection _productService;

        //Mangler url samt port number - sat til null for nu.
        readonly String _serviceBaseUrl = null;

        public ProductServiceAccess()
        {
            _productService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Product>>? GetProducts(int id = -1)
        {
            List<Product> productsFromService = null;

            if (_productService != null)
            {
                _productService.UseUrl = _productService.BaseUrl;
                bool onePersonById = (id > 0);
                if (onePersonById)
                {
                    _productService.UseUrl += id;
                }
                try
                {
                    var serviceResponse = await _productService.CallServiceGet();
                    //If success (200-299)
                    if (serviceResponse is not null && serviceResponse.IsSuccessStatusCode)
                    //200 with data returned
                    {
                        if (serviceResponse.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            //If 1 Product returned - else all Products returned
                            if (oneProductById)
                            {
                                Product foundProduct = JsonConvert.DeserializeObject<Product>(responseData);
                                if (foundProduct != null)
                                {
                                    productsFromService = new List<Product> { foundProduct }; //Must return List

                                }
                            }
                            else
                            {
                                productsFromService = JsonConvert.DeserializeObject<List<Product>>(responseData);
                            }
                            //204 no data
                        }
                        else if (serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            productsFromService = new List<Product>();
                        }
                    }
                }
                catch
                {
                    productsFromService = null;
                }
            }
            return productsFromService;
        }

        public Task<int> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
