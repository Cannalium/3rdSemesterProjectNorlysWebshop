namespace WebshopRestService.BusinessLogicLayer
{
    public interface IProductData
    {
        ProductDTO? Get(int prodId);
        List<ProductDTO>? Get();
        int Add(ProductDTO productToAdd);
        bool Put(ProductDTO productToUpdate);
        bool Delete(int prodId);

    }
}
