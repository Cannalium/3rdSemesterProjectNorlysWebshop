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

        // Retrieves the order ID and OrderLineDetails from TempData, and passes them to the view along with the cart items
        public IActionResult Cart()
        {
            // Retrieve the order ID from TempData
            int? orderId = TempData["OrderId"] as int?;

            // Pass the order ID to the view
            ViewBag.OrderId = orderId;

            // Retrieve OrderLineDetails from TempData
            List<string>? orderLineDetails = TempData["OrderLineDetails"] as List<string>;

            // Pass OrderLineDetails to the view
            ViewBag.OrderLineDetails = orderLineDetails;

            List<OrderLine>? foundCartItems = CartDataControl.ReadCart(HttpContext);
            return View(foundCartItems);
        }

        // Asynchronously adds a product to the shopping cart, updates TempData messages, and redirects to the Product controller's Product action
        public async Task<ActionResult> AddToCart(int prodId, int orderLineProdQuantity)
        {
            bool itemAddedOK = false;

            // Check if the provided product ID and order line quantity are valid
            if (prodId > 0 && orderLineProdQuantity > 0)
            {
                // Retrieve the product details using the ProductController
                var product = await _productController.GetProdById(prodId);

                // Create a new OrderLine representing the selected product and quantity
                OrderLine newCartProdItem = new OrderLine(product, orderLineProdQuantity);

                // Check if the new cart product item is not null
                if (newCartProdItem != null)
                {
                    // Update the shopping cart using CartDataControl.UpdateCart method
                    itemAddedOK = CartDataControl.UpdateCart(HttpContext, newCartProdItem);

                    // Set TempData messages for user feedback
                    TempData["AddedToCartMessage"] = $"{orderLineProdQuantity} x {product.ProdName} tilføjet til indkøbskurv";
                }

                // Set TempData process text based on whether the item was added successfully
                TempData["ProcessText"] = itemAddedOK ? $"Added {orderLineProdQuantity} to cart" : "Error - item was not added!";

                return RedirectToAction("Product", "Product");
            }

            // Set TempData process text for an invalid product ID
            TempData["ProcessText"] = "Error - Invalid product ID";

            return RedirectToAction("Error");
        }

        // Synchronously updates the quantity of a product in the shopping cart, sets TempData messages, and redirects to the Cart action
        public ActionResult UpdateCartItem(int prodId, int orderLineProdQuantity)
        {
            // Retrieve the product details using the ProductController (await the result properly in an asynchronous context)
            var product = _productController.GetProdById(prodId).Result;

            // Create a new OrderLine representing the selected product and updated quantity
            var updatedCartItem = new OrderLine(product, orderLineProdQuantity);

            // Update the shopping cart using CartDataControl.UpdateCartItem method
            bool cartWasUpdated = CartDataControl.UpdateCartItem(HttpContext, updatedCartItem);

            // Set TempData messages for user feedback
            if (cartWasUpdated)
            {
                TempData["ProcessText"] = $"Updated quantity for product {prodId} in the cart";
            }
            else
            {
                TempData["ProcessText"] = $"Error - product {prodId} not found in the cart";
            }
            return RedirectToAction("Cart");
        }

        // Removes a product from the shopping cart, sets TempData messages, and redirects to the Cart action
        public ActionResult RemoveFromCart(int prodId)
        {
            // Call CartDataControl.RemoveFromCart method to remove the specified product from the cart
            bool cartItemRemoved = CartDataControl.RemoveFromCart(HttpContext, prodId);

            // Set TempData messages for user feedback based on the removal result
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

        // Empties the shopping cart, sets TempData messages, and redirects to the Cart action
        public ActionResult EmptyCart()
        {
            // Call CartDataControl.EmptyCart method to delete the cart cookie
            bool wasEmptiedOk = CartDataControl.EmptyCart(HttpContext);

            // Set TempData messages for user feedback based on the cart emptying result
            TempData["ProcessText"] = wasEmptiedOk ? $"The cart was emptied" : "Error - cart was not emptied!";

            return RedirectToAction("Cart");
        }
    }
}

