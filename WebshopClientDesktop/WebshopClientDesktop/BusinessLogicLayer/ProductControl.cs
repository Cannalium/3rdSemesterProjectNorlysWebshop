using WebshopClientDesktop.ModelLayer;
using WebshopClientDesktop.ServiceLayer;

namespace WebshopClientDesktop.BusinessLogicLayer
{
    public class ProductControl
    {
        readonly IProductAccess _productAccess;

        public ProductControl()
        {
            _productAccess = new ProductServiceAccess();
        }

        // Creates a new product with the provided details
        public async Task<int> CreateProduct(string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType)
        {
            // Create a new Product object with the provided details
            Product newProduct = new(prodName, prodDescription, prodPrice, prodQuantity, prodType);

            // Call the data access layer to create the product
            int insertedId = await _productAccess.CreateProduct(newProduct);

            return insertedId;
        }

        // Retrieves all products
        public async Task<List<Product>> GetAllProducts()
        {
            return await _productAccess.GetAllProducts();
        }

        // Retrieves products of a specific type
        public async Task<List<Product>> GetAllProductsByType(string type)
        {
            return await _productAccess.GetAllProductsByType(type);
        }

        // Retrieves all products of the "Event" type
        public async Task<List<Product>> GetAllProductsByEventType()
        {
            return await GetAllProductsByType("Event");
        }

        // Retrieves all products of the "Merch" type
        public async Task<List<Product>> GetAllProductsByMerchType()
        {
            return await GetAllProductsByType("Merch");
        }

        // Updates an existing product
        public async Task<bool> UpdateProduct(Product updatedProduct)
        {
            // Call the data access layer to update the product
            bool isUpdated = await _productAccess.UpdateProduct(updatedProduct);

            return isUpdated;
        }

        // Deletes a product with the specified ID
        public async Task<bool> DeleteProduct(int prodId)
        {
            // Call the data access layer to delete the product
            bool isDeleted = await _productAccess.DeleteProduct(prodId);

            return isDeleted;
        }
    }
}
