using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.ServiceLayer
{
    public interface IProductAccess
    {
        Task<int> CreateProduct(Product productToSave);
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetAllProductsByType(string prodType);
        Task<bool> UpdateProduct(Product productToUpdate);
        Task<bool> DeleteProduct (int prodId);
    }
}
