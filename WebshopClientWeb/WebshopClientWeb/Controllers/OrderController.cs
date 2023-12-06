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
        }

        private decimal CalculateOrderPrice(List<OrderLine>? orderLines)
        {
            decimal orderPrice = 0;
            if (orderLines != null)
            {
                foreach (var orderLine in orderLines)
                {
                    orderPrice += (orderLine.OrderLineProdQuantity * orderLine.CartProduct.ProdPrice);
                }
            }
            return orderPrice;
        }


    }

}

