using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        /*public static bool UpdateCart(HttpContext httpContext, OrderLine newCartProdItem)
         {
             bool cartWasUpdated = false;
             // If cart is empty - appent cart to cookie content
             if (!httpContext.Request.Cookies.ContainsKey("Cart"))
             {
                 List<OrderLine>? cartItems = new List<OrderLine> { newCartProdItem };
                 if (cartItems != null)
                 {
                     httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));
                     cartWasUpdated = true;
                 }
             }
             // If cart has content
             else
             {
                 List<OrderLine> cartItems = ReadCart(httpContext);

                 if (cartItems != null)
                 {
                     OrderLineServiceAccess.UpdateCartProd(cartItems, newCartProdItem);
                     httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));
                     cartWasUpdated = true;
                 }
             }
             return cartWasUpdated;
         } */



        /* public static bool UpdateCart(HttpContext httpContext, OrderLine newCartProdItem)
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
         }*/

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
                // Check if the product is already in the cart
                bool productExistsInCart = false;

                foreach (var cartItem in cartItems)
                {
                    if (cartItem.CartProduct.ProdId == newCartProdItem.CartProduct.ProdId)
                    {
                        // Update the quantity if the product exists
                       OrderLineServiceAccess.UpdateCartProd(cartItems, newCartProdItem);
                        productExistsInCart = true;
                        break; // No need to continue checking
                    }
                }

                if (!productExistsInCart)
                {
                    // Add the new item to the existing cart items
                    cartItems.Add(newCartProdItem);
                }
            }

            // Update the cart cookie
            httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));
            cartWasUpdated = true;

            return cartWasUpdated;
            }

            public static bool RemoveFromCart(HttpContext httpContext, int prodId)
        {
            List<OrderLine>? cartItems = ReadCart(httpContext);

            if (cartItems != null)
            {
                var cartItemToRemove = cartItems.FirstOrDefault(item => item.CartProduct.ProdId == prodId);

                if (cartItemToRemove != null)
                {
                    cartItems.Remove(cartItemToRemove);

                    httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));

                    return true;
                }
            }

            return false;
        }

        public static bool EmptyCart(HttpContext httpContext)
        {
            bool cartWasEmptied = false;
            if (httpContext.Request.Cookies.ContainsKey("cart"))
            {
                httpContext.Response.Cookies.Delete("cart");
                cartWasEmptied = true;
            }
            return cartWasEmptied;
        }
    } 
}

