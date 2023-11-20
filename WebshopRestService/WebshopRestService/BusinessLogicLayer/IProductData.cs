namespace WebshopRestService.BusinessLogicLayer
{
    public interface IProductData
    {
        ProductDTO? Get(int id);
        List<ProductDTO>? Get();
        int Add(ProductDTO productToAdd);
        bool Put(ProductDTO productToUpdate);
        bool Delete(int id);

    }
}
