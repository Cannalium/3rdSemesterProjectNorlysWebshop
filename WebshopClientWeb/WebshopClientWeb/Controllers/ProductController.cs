using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Logging;
using WebshopClientWeb.Model;
using WebshopClientWeb.ServiceLayer;

namespace WebshopClientWeb.Controllers
{

    public class ProductController : Controller
    {
            private ProductDataControl _productDataControl;

            public ProductController()
            {
                _productDataControl = new ProductDataControl();
            }

        [Route("Product")]
        public async Task<IActionResult> Product()
        {
            // Get products by type (e.g., "Event")
            List<Product> products = await GetAllProducts();

            // Pass the products to the view
            return View(products);
        }

        public async Task<List<Product>> GetAllProductsByType(string type)
        {
            Logger.LogInfo($"Getting all products by type. Type: {type}");
            return await _productDataControl.GetAllProductsByType(type);

        }

        public async Task<List<Product>> GetAllProductsByEventType()
        {
            return await GetAllProductsByType("Event");
        }

        public async Task<List<Product>> GetAllProductsByMerchType()
        {
            return await GetAllProductsByType("Merch");
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _productDataControl.GetAllProducts();
        }
    }
}
