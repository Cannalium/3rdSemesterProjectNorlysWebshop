using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class ProductController : Controller
    {
        private ProductDataControl _productDataControl;

        public ProductController()
        {
            _productDataControl = new ProductDataControl();

        }

        // Retrieves and displays all products on the "Product" page
        [Route("Product")]
        public async Task<IActionResult> Product()
        {
            // Get products by type (e.g., "Event")
            List<Product> products = await GetAllProducts();

            // Pass the products to the view
            return View(products);
        }

        // Retrieves all products from the data control layer
        public async Task<List<Product>> GetAllProducts()
        {
            return await _productDataControl.GetAllProducts();
        }

        // Retrieves a product by its ID from the data control layer
        public async Task<Product> GetProdById(int prodId)
        {
            return await _productDataControl.GetProdById(prodId);
        }
    }
}
