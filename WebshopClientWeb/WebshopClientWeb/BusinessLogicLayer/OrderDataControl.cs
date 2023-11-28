using System.Net;
using WebshopClientWeb.ServiceLayer;

namespace WebshopClientWeb.BusinessLogicLayer
{
    public class OrderDataControl
    {
        readonly IOrderServiceAccess _OrderAccess;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public OrderDataControl()
        {
            _OrderAccess = new OrderServiceAccess();
        }
    }
}
