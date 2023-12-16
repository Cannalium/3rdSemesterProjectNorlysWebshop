using Newtonsoft.Json;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.BusinessLogicLayer
{
    public class CartDataControl
    {
        // Reads the shopping cart from the HttpContext cookies, returning a list of OrderLine objects or null if the cart is not found
        public static List<OrderLine>? ReadCart(HttpContext httpContext)
        {
            List<OrderLine>? foundCartItems = null;

            // Check if the "cart" key exists in the request cookies
            if (httpContext.Request.Cookies.ContainsKey("cart"))
            {
                // Retrieve the cart data from the cookies
                var cookieData = httpContext.Request.Cookies["cart"];

                // Deserialize the cart data into a list of OrderLine objects
                if (cookieData != null)
                {
                    foundCartItems = JsonConvert.DeserializeObject<List<OrderLine>>(cookieData);
                }
            }
            return foundCartItems;
        }

        // Updates the shopping cart in the HttpContext cookies with a new or modified OrderLine, returning true if the cart was successfully updated
        public static bool UpdateCartItem(HttpContext httpContext, OrderLine newCartProdItem)
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
                OrderLine existingItem = cartItems.Find(item => item.CartProduct.ProdId == newCartProdItem.CartProduct.ProdId);

                if (existingItem != null)
                {
                    // Update the quantity if the product exists
                    existingItem.OrderLineProdQuantity = newCartProdItem.OrderLineProdQuantity;
                }
                else
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

        // Updates the shopping cart in the HttpContext cookies with a new or modified OrderLine, returning true if the cart was successfully updated
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
                        UpdateCartProd(cartItems, newCartProdItem);
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


        // Updates the quantity of an existing product in the shopping cart list, combining it with a new product if already present
        public static void UpdateCartProd(List<OrderLine> cartProducts, OrderLine newCartProduct)
        {
            bool wasInCart = false;

            // Check if the provided list of cart products and the new cart product are not null
            if (cartProducts != null && newCartProduct != null)
            {
                // Iterate through each existing product in the cart
                foreach (OrderLine cartProduct in cartProducts)
                {
                    // Check if both the existing and new products have non-null CartProduct properties
                    if (cartProduct.CartProduct != null && newCartProduct.CartProduct != null)
                    {
                        // Check if the ProdId of the existing and new products match
                        if (cartProduct.CartProduct.ProdId == newCartProduct.CartProduct.ProdId)
                        {
                            // If found, increment the quantity of the existing product in the cart
                            cartProduct.OrderLineProdQuantity += newCartProduct.OrderLineProdQuantity;
                            wasInCart = true;
                        }
                    }
                }
            }
        }

        // Removes a product with the specified ID from the shopping cart, updating the cart cookie
        public static bool RemoveFromCart(HttpContext httpContext, int prodId)
        {
            // Read the current cart items from the HttpContext cookies
            List<OrderLine>? cartItems = ReadCart(httpContext);

            // Check if the cart is not null
            if (cartItems != null)
            {
                // Attempt to locate the product with the specified ID in the cart
                var cartItemToRemove = cartItems.FirstOrDefault(item => item.CartProduct.ProdId == prodId);

                // If the product is found in the cart
                if (cartItemToRemove != null)
                {
                    // Remove the product from the cart items list
                    cartItems.Remove(cartItemToRemove);

                    // Update the cart cookie with the modified cart items
                    httpContext.Response.Cookies.Append("cart", JsonConvert.SerializeObject(cartItems));

                    return true;
                }
            }
            return false;
        }

        // Empties the shopping cart by deleting the cart cookie
        public static bool EmptyCart(HttpContext httpContext)
        {
            bool cartWasEmptied = false;

            // Check if the "cart" key exists in the request cookies
            if (httpContext.Request.Cookies.ContainsKey("cart"))
            {
                // Delete the "cart" cookie from the response
                httpContext.Response.Cookies.Delete("cart");

                // Set the flag to indicate that the cart was successfully emptied
                cartWasEmptied = true;
            }
            return cartWasEmptied;
        }
    }
}
