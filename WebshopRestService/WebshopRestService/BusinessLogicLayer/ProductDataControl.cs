using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;
using WebshopRestService.Logging;

namespace WebshopRestService.BusinessLogicLayer
{
    public class ProductDataControl : IProductData
    {
        private readonly IProductAccess _productAccess;

        public ProductDataControl(IProductAccess ProductAccess)
        {
            _productAccess = ProductAccess;
        }

        // Creates a new Product in the database from a ProductDTOWrite using ModelConversion and returns the generated prodId
        public int CreateProduct(ProductDTOWrite productToCreate)
        {
            int insertedId = 0;
            try
            {
                Product? foundProduct = ModelConversion.ProductDTOConversion.ToProduct(productToCreate);
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

        // Deletes a Product from the database based on the provided prodId using ProductAccess and returns true if successful
        public bool DeleteProductById(int prodId)
        {
            try
            {
                bool deletionSuccessful = _productAccess.DeleteProductById(prodId);
                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        // Retrieves a ProductDTORead from the database based on the provided prodId using ProductAccess and ModelConversion, handling exceptions
        public ProductDTORead? GetProductById(int prodId)
        {
            ProductDTORead? foundProductDTO;
            try
            {
                Product? foundProduct = _productAccess.GetProductById(prodId);
                foundProductDTO = ModelConversion.ProductDTOConversion.FromProduct(foundProduct);
            }
            catch(Exception ex)
            {
                foundProductDTO = null;
                Logger.LogError(ex);
            }
            return foundProductDTO;
        }

        // Retrieves a list of ProductDTORead objects based on the provided prodType using ProductAccess and ModelConversion, handling exceptions
        public List<ProductDTORead> GetProductByType(string prodType)
        {
            List<ProductDTORead> foundProductsDTO;
            try
            {
                List<Product> foundProducts = _productAccess.GetProductByType(prodType);
                foundProductsDTO = ModelConversion.ProductDTOConversion.FromProductCollection(foundProducts);
            }
            catch(Exception ex)
            {
                //Instead of null - create a new empty list
                foundProductsDTO = new List<ProductDTORead>();
                Logger.LogError(ex);
            }
            return foundProductsDTO;
        }

        // Retrieves a list of all ProductDTORead objects from the database using ProductAccess and ModelConversion
        public List<ProductDTORead> GetAllProducts()
        {
            List<ProductDTORead> foundDTOs;
            try
            {
                List<Product> foundProducts = _productAccess.GetAllProducts();
                foundDTOs = ModelConversion.ProductDTOConversion.FromProductCollection(foundProducts);
            }
            catch (Exception ex)
            {
                foundDTOs = new List<ProductDTORead>();
                Logger.LogError(ex);
            }
            return foundDTOs;
        }

        // Updates a Product in the database based on the provided ProductDTOWrite using ModelConversion and ProductAccess, handling exceptions
        public bool UpdateProduct(ProductDTOWrite productToUpdate)
        {
            try
            {
                Product updatedProduct = ModelConversion.ProductDTOConversion.ToProduct(productToUpdate);

                if (updatedProduct != null)
                {
                    bool updateSuccessful = _productAccess.UpdateProduct(updatedProduct);
                    return updateSuccessful;
                }
                return false;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return false;
            }
        }
    }
}
