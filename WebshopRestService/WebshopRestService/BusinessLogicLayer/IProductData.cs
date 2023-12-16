using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IProductData
    {
        int Add(ProductDTOWrite productToAdd);
        ProductDTORead? Get(int prodId);
        List<ProductDTORead> GetProductByType(string prodType);
        List<ProductDTORead>? Get();
        bool Put(ProductDTOWrite productToUpdate);
        bool Delete(int prodId);
    }
}
