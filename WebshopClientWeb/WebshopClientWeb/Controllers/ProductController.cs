using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;

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
    }
}
