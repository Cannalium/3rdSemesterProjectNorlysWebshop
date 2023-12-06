using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IProductData
    {
        ProductDTORead? Get(int prodId);
        List<ProductDTORead> GetProductByType(string prodType);
        List<ProductDTORead>? Get();
        int Add(ProductDTOWrite productToAdd);
        bool Put(ProductDTOWrite productToUpdate);
        bool Delete(int prodId);
    }
}
