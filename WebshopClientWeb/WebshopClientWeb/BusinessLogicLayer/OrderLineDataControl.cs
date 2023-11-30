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
            // If cart empty - append 'cart' to cookie content
            if (!httpContext.Request.Cookies.ContainsKey("cart"))
            {
                List<OrderLine> cartItems = new List<OrderLine>() { newCartProdItem };
                if (cartItems != null)
                {
                    httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));
                    cartWasUpdated = true;
                }
            }
                return cartWasUpdated;
            }
        }
    }

