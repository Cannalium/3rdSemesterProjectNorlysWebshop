using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;

namespace WebshopRestService.BusinessLogicLayer
{
    public class ProductDataControl : IProductData
    {
        private readonly IProductAccess _productAccess;

        public ProductDataControl(IProductAccess inProductAccess)
        {
            _productAccess = inProductAccess;

        }
        public int Add(ProductDTO productToAdd)
        {
            int insertedId = 0;
            try
            {
                Product? foundProduct = ModelConversion.ProductDtoConvert.ToProduct(newProduct);
                if (foundProduct != null)
                {
                    insertedId = _productAccess.CreateProduct(foundProduct);
                }
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int id)
        {
            try
            {
                bool deletionSuccessful = _productAccess.DeleteProduct(id);

                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public ProductDTO? Get(int id)
        {
            ProductDTO? foundProductDto;
            try
            {
                Product? foundProduct = _productAccess.GetProductById(idToMatch);
                foundProductDto = ModelConversion.ProductDtoConvert.FromProduct(foundProduct);
            }
            catch
            {
                foundProductDto = null;
            }
            return foundProductDto;
        }

        public List<ProductDTO>? Get()
        {
            List<ProductDTO>? foundDtos;
            try
            {
                List<Product>? foundProducts = _productAccess.GetProductAll();
                foundDtos = ModelConversion.ProductDtoConvert.FromProductCollection(foundProducts);
            }
            catch
            {
                foundDtos = null;
            }
            return foundDtos;

        }

        public bool Put(ProductDTO productToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
