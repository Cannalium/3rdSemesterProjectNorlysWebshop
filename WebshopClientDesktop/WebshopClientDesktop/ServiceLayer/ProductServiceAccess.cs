using Newtonsoft.Json;
using System.Text;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.ServiceLayer
{
    public class ProductServiceAccess : IProductAccess
    {
        readonly ServiceConnection _productService;

        readonly String _serviceBaseUrl = "https://localhost:7173/api/product";

        public ProductServiceAccess()
        {
            _productService = new ServiceConnection(_serviceBaseUrl);
        }

        // Creates a new product by sending a POST request to the ProductService API
        public async Task<int> CreateProduct(Product productToSave)
        {
            int insertedProdId = -1;
            _productService.UseUrl = _productService.BaseUrl;

            try
            {
                // Serialize the product to JSON
                string jsonProduct = JsonConvert.SerializeObject(productToSave);
                var httpContent = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                // Call the ProductService API to create a new product
                var serviceRespone = await _productService.CallServicePost(httpContent);

                // If successful HTTP status code 200-299
                if (serviceRespone is not null && serviceRespone.IsSuccessStatusCode)
                {
                    // Parse the inserted product ID from the response
                    string idString = await serviceRespone.Content.ReadAsStringAsync();
                    bool numOk = Int32.TryParse(idString, out insertedProdId);
                    if (!numOk)
                    {
                        insertedProdId = -2; // Parsing error
                    }
                }
            }
            catch
            {
                insertedProdId = -2; // Exception occurred
            }
            return insertedProdId;
        }

        // Retrieves all products by sending a GET request to the ProductService API
        public async Task<List<Product>> GetAllProducts()
        {
            _productService.UseUrl = $"{_productService.BaseUrl}";

            // Call the ProductService API to get all products
            HttpResponseMessage serviceResponse = await _productService.CallServiceGet();

            if (serviceResponse.IsSuccessStatusCode)
            {
                // Parse the response data into a list of products
                string responseData = await serviceResponse.Content.ReadAsStringAsync();
                List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(responseData);

                // Check if the deserialization was successful
                if (products == null)
                {
                    return new List<Product>();
                }
                return products;
            }
            else
            {
                return new List<Product>(); // Error occurred
            }
        }

        // Retrieves products by type by sending a GET request to the ProductService API
        public async Task<List<Product>> GetAllProductsByType(string prodType)
        {
            _productService.UseUrl = $"{_productService.BaseUrl}?prodType={prodType}";

            // Call the ProductService API to get products by type
            HttpResponseMessage serviceResponse = await _productService.CallServiceGet();

            if (serviceResponse.IsSuccessStatusCode)
            {
                // Parse the response data into a list of products
                string responseData = await serviceResponse.Content.ReadAsStringAsync();
                List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(responseData);

                // Check if the deserialization was successful
                if (products == null)
                {
                    return new List<Product>();
                }
                return products;
            }
            else
            {
                return new List<Product>(); // Error occurred
            }
        }

        // Updates a product by sending a PUT request to the ProductService API
        public async Task<bool> UpdateProduct(Product updatedProduct)
        {
            bool isUpdated = false;

            // URL for the specific product
            _productService.UseUrl = $"{_productService.BaseUrl}/{updatedProduct.ProdId}";

            try
            {
                // Serialize the updated product to JSON
                var json = JsonConvert.SerializeObject(updatedProduct);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Call the ProductService API to update the chosen product
                var serviceResponse = await _productService.CallServicePut(content);

                // If successful HTTP status code 200-299
                if (serviceResponse is not null && serviceResponse.IsSuccessStatusCode)
                {
                    isUpdated = true;
                }
            }
            catch
            {
                isUpdated = false;
            }
            return isUpdated;
        }

        // Deletes a product by sending a DELETE request to the ProductService API
        public async Task<bool> DeleteProduct(int prodId)
        {
            bool isDeleted = false;
            _productService.UseUrl = $"{_productService.BaseUrl}/{prodId}";

            try
            {
                // Call the ProductService API to delete the chosen product
                var serviceResponse = await _productService.CallServiceDelete();

                // If successful HTTP status code 200-299
                if (serviceResponse is not null && serviceResponse.IsSuccessStatusCode)
                {
                    isDeleted = true;
                }
            }
            catch
            {
                isDeleted = false; // Exception occurred
            }
            return isDeleted;
        }
    }
}
