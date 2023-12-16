using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IProductAccess
    {
        int CreateProduct(Product productToCreate);
        List<Product> GetAllProducts();
        Product GetProductById(int prodId);
        List<Product> GetProductByType(string prodType);
        bool UpdateProduct(Product productToUpdate);
        bool DeleteProductById(int prodId);
    }
}
