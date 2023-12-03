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

        public async Task<ActionResult> AddToCart(int prodId, int orderLineProdQuantity)
        {
            bool itemAddedOK = false;
            if (prodId > 0 && orderLineProdQuantity > 0)
            {
                var product = await _productController.GetProdById(prodId);
                OrderLine newCartProdItem = new OrderLine(product, orderLineProdQuantity);
                if (newCartProdItem != null)
                {
                    itemAddedOK = OrderLineDataControl.UpdateCart(HttpContext, newCartProdItem);
                }
                TempData["ProcessText"] = itemAddedOK ? $"Added {orderLineProdQuantity} to cart" : "Error - item was not added!";
                return RedirectToAction("Cart");
            }
            TempData["ProcessText"] = "Error - Invalid product ID";
            return RedirectToAction("Error");
        }

        public ActionResult RemoveFromCart(int prodId)
        {
            bool cartItemRemoved = OrderLineDataControl.RemoveFromCart(HttpContext, prodId);

            if (cartItemRemoved)
            {
                TempData["ProcessText"] = $"Removed product {prodId} from the cart";
            }
            else
            {
                TempData["ProcessText"] = $"Error - product {prodId} not found in the cart";
            }

            return RedirectToAction("Cart");
        }

        public ActionResult EmptyCart()
        {
            bool wasEmptiedOk = OrderLineDataControl.EmptyCart(HttpContext);
            TempData["ProcessText"] = wasEmptiedOk ? $"The cart was emptied" : "Error - cart was not emtied!";
            return RedirectToAction("Cart");
        }

    }     
}

