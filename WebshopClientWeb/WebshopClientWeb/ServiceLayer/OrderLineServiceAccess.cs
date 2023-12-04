using System.Net;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class OrderLineServiceAccess : IOrderLineServiceAccess
    {
        readonly IServiceConnection _orderLineService;
        readonly String _serviceBaseUrl = "https://localhost:7173/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public OrderLineServiceAccess()
        {
            _orderLineService = new ServiceConnection(_serviceBaseUrl);
        }
    }
}
