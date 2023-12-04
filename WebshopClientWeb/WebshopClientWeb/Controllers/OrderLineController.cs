using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class OrderLineController : Controller
    {
        private OrderLineDataControl _orderLineDatacontrol;
        private ProductController _productController;


        public OrderLineController()
        {
            _orderLineDatacontrol = new OrderLineDataControl();
            _productController = new ProductController();
        }
    }    
}

