using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class OrderLineController : Controller
    {
        private OrderLineDataControl _orderLineDatacontrol;
        private ProductController _productController;
        

        public OrderLineController()
        {
            _orderLineDatacontrol = new OrderLineDataControl();
            _productController = new ProductController();
        }

        public IActionResult Cart()
        {
            List<OrderLine>? foundCartItems = OrderLineDataControl.ReadCart(HttpContext);
            return View(foundCartItems);
        }

        public async Task<ActionResult> AddToCart(int prodId)
        {
            bool itemAddedOK = false;
            if (prodId > 0)
            {
                var product = await _productController.GetProdById(prodId);
                OrderLine newCartProdItem = new OrderLine(product);
                if (newCartProdItem != null)
                {
                    itemAddedOK = OrderLineDataControl.UpdateCart(HttpContext, newCartProdItem);
                }

                TempData["ProcessText"] = itemAddedOK ? $"Added {prodId} to cart" : "Error - item was not added!";
                return Redirect("Cart");
            }

            TempData["ProcessText"] = "Error - Invalid product ID";
            return Redirect("Error");
        }

        public ActionResult EmptyCart()
        {
            bool wasEmptiedOk = OrderLineDataControl.EmptyCart(HttpContext);
            TempData["ProcessText"] = wasEmptiedOk ? $"The cart was emptied" : "Error - cart was not emtied!";
            return Redirect("Cart");
        }

    }     
}

