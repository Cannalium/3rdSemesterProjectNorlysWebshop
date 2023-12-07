using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text;
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

        public async Task<ActionResult> CreateOrder()
        {
            // person fra login metode?
            string? email = HttpContext.User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
            {
                // if email is not available
                Console.WriteLine("email not available");
            }

            // Get cart items from cookies or session
            List<OrderLine>? cartOrderLines = CartDataControl.ReadCart(HttpContext);

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

            // Pass the order to the OrderDataControl to create the order
            int insertedId = await _orderDataControl.CreateOrder(orderToCreate);

            return RedirectToAction("Cart", "cart");
        }




        /*public async Task<ActionResult> CreateOrder()
        {
            //person fra login metode?
            string? email = HttpContext.User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
            {
                // if email is not available
                Console.WriteLine("email not available");
            }

            // Get cart items from cookies or session
            List<OrderLine>? orderLines = CartDataControl.ReadCart(HttpContext);

            // Calculate order price based on cart items
            decimal orderPrice = CalculateOrderPrice(orderLines);

            // Create an order using the retrieved person and cart items
            Person? personFromService = await _personDataControl.GetPersonByEmail(email);
            Order orderToCreate = new(personFromService, orderPrice, orderLines);

            // Pass the order to the OrderDataControl to create the order
            int insertedId = await _orderDataControl.CreateOrder(orderToCreate);

            return RedirectToAction("Cart", "cart");
        }*/

        private decimal CalculateOrderPrice(List<OrderLine>? cartOrderLines)
        {
            decimal orderPrice = 0;
            if (cartOrderLines != null)
            {
                foreach (var orderLine in cartOrderLines)
                {
                    orderPrice += (orderLine.OrderLineProdQuantity * orderLine.CartProduct.ProdPrice);
                }
            }
            return orderPrice;
        }


    }

}

