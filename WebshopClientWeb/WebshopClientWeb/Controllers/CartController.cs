using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class CartController : Controller
    {
        private CartDataControl _cartDatacontrol;
        private ProductController _productController;


        public CartController()
        {
            _cartDatacontrol = new CartDataControl();
            _productController = new ProductController();
        }

        public IActionResult Cart()
        {
            List<OrderLine>? foundCartItems = CartDataControl.ReadCart(HttpContext);
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
                    itemAddedOK = CartDataControl.UpdateCart(HttpContext, newCartProdItem);
                    TempData["AddedToCartMessage"] = $"{orderLineProdQuantity} x {product.ProdName} tilføjet til indkøbskurv";
                }
                TempData["ProcessText"] = itemAddedOK ? $"Added {orderLineProdQuantity} to cart" : "Error - item was not added!";
                return RedirectToAction("Product", "Product");
            }
            TempData["ProcessText"] = "Error - Invalid product ID";
            return RedirectToAction("Error");
        }

        public ActionResult RemoveFromCart(int prodId)
        {
            bool cartItemRemoved = CartDataControl.RemoveFromCart(HttpContext, prodId);

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
            bool wasEmptiedOk = CartDataControl.EmptyCart(HttpContext);
            TempData["ProcessText"] = wasEmptiedOk ? $"The cart was emptied" : "Error - cart was not emtied!";
            return RedirectToAction("Cart");
        }

    }
}

