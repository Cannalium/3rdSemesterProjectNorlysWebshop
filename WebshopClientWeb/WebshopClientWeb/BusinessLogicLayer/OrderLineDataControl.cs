using Newtonsoft.Json;
using System.Net;
using WebshopClientWeb.Model;
using WebshopClientWeb.ServiceLayer;

namespace WebshopClientWeb.BusinessLogicLayer
{
    public class OrderLineDataControl
    {
        readonly IOrderLineServiceAccess _OrderLineAccess;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public OrderLineDataControl()
        {
            _OrderLineAccess = new OrderLineServiceAccess();
        }

        public static List<OrderLine>? ReadCart(HttpContext httpContext)
        {
            List<OrderLine>? foundCartItems = null;
            if (httpContext.Request.Cookies.ContainsKey("cart"))
            {
                var cookieData = httpContext.Request.Cookies["cart"];
                if (cookieData != null)
                {
                    foundCartItems = JsonConvert.DeserializeObject<List<OrderLine>>(cookieData);
                }
            }
            return foundCartItems;
        }

        public static bool UpdateCart(HttpContext httpContext, OrderLine newCartProdItem)
        {
            bool cartWasUpdated = false;

            // Read existing cart items
            List<OrderLine>? cartItems = ReadCart(httpContext);

            if (cartItems == null)
            {
                // If cart is empty, create a new list with the new item
                cartItems = new List<OrderLine> { newCartProdItem };
            }
            else
            {
                // Add the new item to the existing cart items
                cartItems.Add(newCartProdItem);
            }

            // Update the cart cookie
            httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));
            cartWasUpdated = true;

            return cartWasUpdated;
        }


        public static bool EmptyCart(HttpContext httpContext)
        {
            bool cartWasEmtied = false;
            if (httpContext.Request.Cookies.ContainsKey("cart"))
            {
                httpContext.Response.Cookies.Delete("cart");
                cartWasEmtied = true;
            }
            return cartWasEmtied;
        }
    } 
}

