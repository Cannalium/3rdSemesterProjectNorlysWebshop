using Newtonsoft.Json;
using System.Net;
using System.Text;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class OrderServiceAccess : IOrderServiceAccess
    {
        readonly IServiceConnection _orderService;
        readonly String _serviceBaseUrl = "https://localhost:7173/api/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public OrderServiceAccess()
        {
            _orderService = new ServiceConnection(_serviceBaseUrl);
        }

        // Creates an order by sending a POST request to the OrderService, handling various HTTP status codes and exceptions
        public async Task<int> CreateOrder(Order orderToCreate)
        {
            int insertedOrderId = -1;
            _orderService.UseUrl = _orderService.BaseUrl + "Order";

            if (_orderService != null)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(orderToCreate);
                    var inContent = new StringContent(json, Encoding.UTF8, "application/json");

                    var serviceResponse = await _orderService.CallServicePost(inContent);
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                    {
                        string idString = await serviceResponse.Content.ReadAsStringAsync();
                        bool numOk = Int32.TryParse(idString, out insertedOrderId);
                        if (!numOk)
                        {
                            insertedOrderId = -4; // If parsing of idString fails 
                        }
                    }
                    if (serviceResponse != null && serviceResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        insertedOrderId = -2; // If not found (404) recieved
                    }
                    if (serviceResponse != null && serviceResponse.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        insertedOrderId = -3; // If conflict (409) recieved
                    }
                }
                catch
                {
                    insertedOrderId = -1;
                }
            }
            return insertedOrderId;
        }
    }
}
