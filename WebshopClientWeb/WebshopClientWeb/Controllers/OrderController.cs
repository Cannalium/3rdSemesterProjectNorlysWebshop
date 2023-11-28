using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class OrderController : Controller
    {
        private OrderDataControl _orderDataControl;

        public OrderController()
        {
            _orderDataControl = new OrderDataControl();
        }

        public IActionResult Cart()
        {
            return View();
        }

        
        }

    }

