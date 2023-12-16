using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IProductAccess
    {
        List<Product> GetProductAll();
        int CreateProduct(Product productToCreate);
        Product GetProductById(int prodId);
        List<Product> GetProductByType(string prodType);
        bool UpdateProduct(Product productToUpdate);
        bool DeleteProduct(int prodId);
    }
}
