using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class ProductDTOConversion
    {
        // Convert from Product objects to ProductDTO objects
        public static List<ProductDTO>? FromProductCollection(List<Product> inProducts)
        {
            List<ProductDTO>? aProductReadDTOList = null;
            if (inProducts != null)
            {
                aProductReadDTOList = new List<ProductDTO>();
                ProductDTO? tempDTO;
                foreach (Product aProduct in inProducts)
                {
                    if (aProduct != null)
                    {
                        tempDTO = FromProduct(aProduct);
                        aProductReadDTOList.Add(tempDTO);
                    }
                }
            }
            return aProductReadDTOList;
        }

        // Convert from Person object to PersonDTO object
        public static ProductDTO? FromProduct(Product inProduct)
        {
            ProductDTO? aProductReadDTO = null;
            if (inProduct != null)
            {
                aProductReadDTO = new ProductDTO(inProduct.ProdName, inProduct.ProdDescription, inProduct.ProdPrice, inProduct.ProdQuantity, inProduct.ProdType);
            }
            return aProductReadDTO;
        }

        // Convert from PersonDTO object to Person object
        public static Product? ToProduct(ProductDTO inDTO)
        {
            Product? aProduct = null;
            if (inDTO != null)
            {
                aProduct = new Product(inDTO.ProdName, inDTO.ProdDescription, inDTO.ProdPrice, inDTO.ProdQuantity, inDTO.ProdType);
            }
            return aProduct;
        }
    }
}
