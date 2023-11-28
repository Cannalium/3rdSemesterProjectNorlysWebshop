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

        [Route("Product")]
        public IActionResult Product()
        {
            return View();
        }

        public async Task<IActionResult> GetProducts()
        {
            List<Product> products = await _productDataControl.GetProducts();
            return View(products);
        }
    }
}
