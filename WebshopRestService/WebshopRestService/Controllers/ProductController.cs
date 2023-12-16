using Microsoft.AspNetCore.Mvc;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductData _productDataControl;

        // Constructor with Dependency Injection
        public ProductController(IProductData productDataController)
        {
            _productDataControl = productDataController;
        }

        /*This method retrieves a list of products based on a specified type or all products if no type is specified, 
         * and the HTTP status codes convey the success or failure to the client.
         */
        // URL: api/products
        [HttpGet]
        public ActionResult<List<ProductDTORead>>? GetProducts(string? prodType = "%")
        {
            ActionResult<List<ProductDTORead>> foundReturn;
            List<ProductDTORead>? foundProducts = null;

            // Retrieve data converted to DTO
            if (prodType != "%")
            {
                foundProducts = _productDataControl.GetProductByType(prodType);
            }
            else
            {
                foundProducts = _productDataControl.GetAllProducts();
            }

            // Evaluate
            if (foundProducts != null)
            {
                if (foundProducts.Count > 0)
                {
                    foundReturn = Ok(foundProducts); //Ok found statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); // Ok found, no content statuscode 204
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500); // Internal server error   
            }
            return foundReturn;
        }

        // Retrieves a product by ID and responds with appropriate status; handles exceptions
        // URL: api/products/{id}
        [HttpGet, Route("{prodId}")]
        public ActionResult<ProductDTORead> GetProductById(int prodId)
        {
            ActionResult<ProductDTORead> foundReturn;
            try
            {
                // Retieve data converted to DTO
                ProductDTORead? foundProductsById = _productDataControl.GetProductById(prodId);

                // Evaluate
                if (foundProductsById != null)
                {
                    foundReturn = Ok(foundProductsById); // Ok found product by ID statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); // Ok not found, no content statuscode 204
                }
            }
            catch
            {
                foundReturn = new StatusCodeResult(500); // Internal server error   
            }
            return foundReturn;
        }

        // Creates a new product and responds with appropriate status; handles missing input with BadRequest and exceptions with 500 status
        // URL: api/products
        [HttpPost]
        public ActionResult<int> CreateProduct(ProductDTOWrite productDTO)
        {
            ActionResult<int> foundReturn;
            int insertedId = -1;

            if (productDTO != null)
            {
                insertedId = _productDataControl.CreateProduct(productDTO);
            }

            // Evaluate
            if (insertedId > 0)
            {
                foundReturn = Ok(insertedId); // 200 found
            }
            else if (insertedId == 0)
            {
                foundReturn = BadRequest(); // Missing input
            }
            else
            {
                foundReturn = new StatusCodeResult(500); // Internal server error
            }
            return foundReturn;
        }

        // Deletes a product by ID and responds with Ok if successful, or 500 if an internal server error occurs
        [HttpDelete, Route("{prodId}")]
        public ActionResult DeleteProdutById(int prodId)
        {
            ActionResult foundReturn;

            bool wasOk = _productDataControl.DeleteProductById(prodId);
            if (wasOk)
            {
                foundReturn = Ok(); // 200 found
            }
            else
            {
                foundReturn = new StatusCodeResult(500); // Internal server error
            }
            return foundReturn;
        }

        // Updates a product and responds with Ok if successful, BadRequest for missing input, or 500 for an internal server error
        [HttpPut, Route("{prodId}")]
        public ActionResult<bool> UpdateProduct(ProductDTOWrite productDTO)
        {
            ActionResult foundReturn;

            // Retrieve and convert data
            WebshopModel.ModelLayer.Product? product = ModelConversion.ProductDTOConversion.ToProduct(productDTO);

            if (productDTO != null)
            {
                bool wasOk = _productDataControl.UpdateProduct(productDTO);

                if (wasOk)
                {
                    foundReturn = Ok(); // 200 found
                }
                else
                {
                    foundReturn = new StatusCodeResult(500); // Internal server error
                }
            }
            else
            {
                foundReturn = BadRequest();
            }
            return foundReturn;
        }
    }
}
