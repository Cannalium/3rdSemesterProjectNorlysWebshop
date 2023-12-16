using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class OrderController : Controller
    {
        private OrderDataControl _orderDataControl;
        private PersonDataControl _personDataControl;

        public OrderController()
        {
            _orderDataControl = new OrderDataControl();
            _personDataControl = new PersonDataControl();
        }

        /* Creates an order using the person's email and cart items, calculates the order price, 
         * passes the order to OrderDataControl for creation, updates TempData, empties the cart, 
         * and redirects to the Cart action*/
        public async Task<ActionResult> CreateOrder()
        {
            // Retrieves the email claim from the current user's claims using HttpContext, storing it in the 'email' variable
            string? email = HttpContext.User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
            {
                // If email is not available
                Console.WriteLine("email not available");
            }

            // Get cart items from cookies or session
            List<OrderLine>? cartOrderLines = CartDataControl.ReadCart(HttpContext);

            // Check if the cart is empty
            if (cartOrderLines == null || cartOrderLines.Count == 0)
            {
                // If the cart is empty, return a message
                TempData["CartEmptyMessage"] = "Indkøbskurven er tom.";
                return RedirectToAction("Cart", "cart");
            }

            // Create a new list to store the modified OrderLines
            List<OrderLine> orderLines = new List<OrderLine>();

            foreach (OrderLine cartOrderLine in cartOrderLines)
            {
                // Assuming CartProduct is of type Product
                Product cartProduct = cartOrderLine.CartProduct;

                // Extracting ProdId from the Product in the original list
                int prodId = cartProduct.ProdId;

                // Creating a new OrderLine with ProdId and orderLineProdQuantity
                OrderLine newOrderLine = new OrderLine(prodId, cartOrderLine.OrderLineProdQuantity);

                // Adding the new OrderLine to the new list
                orderLines.Add(newOrderLine);
            }

            // Calculate order price based on the modified cart items
            decimal orderPrice = CalculateOrderPrice(cartOrderLines);

            // Create an order using the retrieved person and modified cart items
            Person? personFromService = await _personDataControl.GetPersonByEmail(email);
            Order orderToCreate = new Order(personFromService, orderPrice, orderLines);

            try
            {
                // Pass the order to the OrderDataControl to create the order
                int insertedId = await _orderDataControl.CreateOrder(orderToCreate);
                
                    // Set a TempData value to hold the order ID for the next request
                    TempData["OrderId"] = insertedId;

                    // Empty the cart
                    CartDataControl.EmptyCart(HttpContext);

                    // Redirect to the Cart action
                    return RedirectToAction("Cart", "Cart");
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error creating order: {ex.Message}");

                // Return an error message as JSON
                return Json(new { success = false, errorMessage = "Error creating order" });
            }
        }

        // Calculates the total order price based on the provided list of cart order lines
        private decimal CalculateOrderPrice(List<OrderLine>? cartOrderLines)
        {
            decimal orderPrice = 0;

            // Check if the provided list of cartOrderLines is not null
            if (cartOrderLines != null)
            {
                // Iterate through each OrderLine in the cartOrderLines list
                foreach (var orderLine in cartOrderLines)
                {
                    // Calculate the product of OrderLineProdQuantity and ProdPrice, and add it to the orderPrice
                    orderPrice += (orderLine.OrderLineProdQuantity * orderLine.CartProduct.ProdPrice);
                }
            }
            return orderPrice;
        }
    }
}

