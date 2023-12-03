using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IProductData
    {
        ProductDTORead? Get(int prodId);
        List<ProductDTORead> GetProductByType(string prodType);
        List<ProductDTORead>? Get();
        int Add(ProductDTORead productToAdd);
        bool Put(ProductDTORead productToUpdate);
        bool Delete(int prodId);
    }
}
