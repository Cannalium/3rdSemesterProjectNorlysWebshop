using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebshopModel.ModelLayer;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductData _productDataController;

        // Constructor with Dependency Injection
        public ProductController(IProductData productDataController)
        {
            _productDataController = productDataController;
        }

        // URL: api/products
        [HttpGet]
        public ActionResult<List<ProductDTO>>? Get()
        {
            ActionResult<List<ProductDTO>> foundReturn;
            //Retrieve data converted to DTO
            List<ProductDTO>? foundProducts = _productDataController.Get();
            //evaluate
            if (foundProducts != null)
            {
                if (foundProducts.Count > 0)
                {
                    foundReturn = Ok(foundProducts); //OK found list statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); //OK found list but no content 204
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500); //Internal server error   
            }
            return foundReturn; //send return to client
        }


        // URL: api/products/{id}
        [HttpGet, Route("{prodId}")]
        public ActionResult<ProductDTO> Get(int prodId)
        {
            ActionResult<ProductDTO> foundReturn;
            try
            {
                //Retieve data converted to DTO
                ProductDTO? foundProductsById = _productDataController.Get(prodId);

                //Evaluate
                if (foundProductsById != null)
                {
                    foundReturn = Ok(foundProductsById); //OK found product by ID statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); // OK not found, no content statuscode 204
                }
            }
            catch
            {
                foundReturn = new StatusCodeResult(500); // Internal server error   
            }
            return foundReturn; // Send return to client
        }

        // URL: api/products/type/{prodType}
        [HttpGet, Route("type/{prodType}")]
        public ActionResult<List<ProductDTO>> GetProductByType(string prodType)
        {
            ActionResult<List<ProductDTO>> foundReturn;
            try
            {
                //Retieve data converted to DTO
                List<ProductDTO> foundProductsByType = _productDataController.GetProductByType(prodType);

                //Evaluate
                if (foundProductsByType != null)
                {
                    foundReturn = Ok(foundProductsByType); //OK found product by ID statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); // OK not found, no content statuscode 204
                }
            }
            catch
            {
                foundReturn = new StatusCodeResult(500); // Internal server error   
            }
            return foundReturn; // Send return to client
        }

        // URL: api/products
        [HttpPost]
        public ActionResult<int> PostNewProduct(ProductDTO productDTO)
        {
            ActionResult<int> foundReturn;
            int insertedId = -1;
            if (productDTO != null)
            {
                insertedId = _productDataController.Add(productDTO);
            }
            // Evaluate
            if (insertedId > 0)
            {
                foundReturn = Ok(insertedId);
            }
            else if (insertedId == 0)
            {
                foundReturn = BadRequest();     // missing input
            }
            else
            {
                foundReturn = new StatusCodeResult(500);    // Internal server error
            }
            return foundReturn;
        }


        //JEG ER IKKE SIKKER PÅ DE FØLGENDE METODER GRRRRRRRRR

        [HttpDelete]
        public ActionResult Delete(int prodId)
        {
            ActionResult foundReturn;
            bool wasOk = _productDataController.Delete(prodId);
            if (wasOk)
            {
                foundReturn = Ok();
            }
            else
            {
                foundReturn = new StatusCodeResult(500);    // Internal server error
            }
            return foundReturn;
        }

        [HttpPut]
        public ActionResult<bool> Put(ProductDTO productDTO)
        {
            ActionResult foundReturn;

            WebshopModel.ModelLayer.Product? product = ModelConversion.ProductDTOConversion.ToProduct(productDTO);

            if (productDTO != null)
            {
                bool wasOk = _productDataController.Put(productDTO);

                if (wasOk)
                {
                    foundReturn = Ok();
                }
                else
                {
                    foundReturn = new StatusCodeResult(500);
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
