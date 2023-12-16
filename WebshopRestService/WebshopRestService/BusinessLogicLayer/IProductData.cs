using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IProductData
    {
        int CreateProduct(ProductDTOWrite productToCreate);
        List<ProductDTORead>? GetAllProducts();
        ProductDTORead? GetProductById(int prodId);
        List<ProductDTORead> GetProductByType(string prodType);
        bool UpdateProduct(ProductDTOWrite productToUpdate);
        bool DeleteProductById(int prodId);
    }
}
