using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class ProductDTOConversion
    {
        // Convert from Product objects to ProductDTO objects
        public static List<ProductDTORead> FromProductCollection(List<Product> inProducts)
        {
            List<ProductDTORead> aProductReadDTOList = new List<ProductDTORead>();
            
            ProductDTORead tempDTO;
            foreach (Product aProduct in inProducts)
            {
                tempDTO = FromProduct(aProduct);
                aProductReadDTOList.Add(tempDTO);
            }
            return aProductReadDTOList;
        }

        // Convert from Person object to PersonDTO object
        public static ProductDTORead FromProduct(Product inProduct)
        {

            return new ProductDTORead(inProduct.ProdId, inProduct.ProdName, inProduct.ProdDescription, inProduct.ProdPrice, inProduct.ProdQuantity, inProduct.ProdType);
        }

        // Convert from PersonDTO object to Person object
        public static Product ToProduct(ProductDTORead inDTO)
        {
            return new Product(inDTO.ProdId, inDTO.ProdName, inDTO.ProdDescription, inDTO.ProdPrice, inDTO.ProdQuantity, inDTO.ProdType);
        }
    }
}
