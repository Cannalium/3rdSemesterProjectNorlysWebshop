using System.Net;

namespace WebshopClientWeb.ServiceLayer
{
    public class OrderServiceAccess : IOrderServiceAccess
    {
        readonly IServiceConnection _orderService;
        readonly String _serviceBaseUrl = "https://localhost:7173/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public OrderServiceAccess()
        {
            _orderService = new ServiceConnection(_serviceBaseUrl);
        }
    }
}
