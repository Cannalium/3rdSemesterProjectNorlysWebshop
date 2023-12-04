using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class CartServiceAccess : ICartServiceAccess
    {
        readonly IServiceConnection _cartService;
        readonly String _serviceBaseUrl = "https://localhost:7173/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public CartServiceAccess()
        {
            _cartService = new ServiceConnection(_serviceBaseUrl);
        }

        public static void UpdateCartProd(List<OrderLine> cProducts, OrderLine newCartProduct)
        {
            bool wasInCart = false;
            if (cProducts != null && newCartProduct != null)
            {
                foreach (OrderLine cProduct in cProducts)
                {
                    if (cProduct.CartProduct != null && newCartProduct.CartProduct != null)
                    {
                        if (cProduct.CartProduct.ProdId == newCartProduct.CartProduct.ProdId)
                        {
                            cProduct.OrderLineProdQuantity += newCartProduct.OrderLineProdQuantity;
                            wasInCart = true;
                        }
                    }
                }
            }
        }
    }
}
