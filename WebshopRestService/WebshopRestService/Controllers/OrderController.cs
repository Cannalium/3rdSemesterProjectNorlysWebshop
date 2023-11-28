using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderData _orderDataController;

        // Constructor with Dependency Injection
        public OrderController(IOrderData orderDataController)
        {
            _orderDataController = orderDataController;
        }

        // URL: api/Order/Order
        [HttpGet]
        public ActionResult<List<OrderDTO>>? Get()
        {
            ActionResult<List<OrderDTO>> foundReturn;
            //Retrieve data converted to DTO
            List<OrderDTO>? foundOrders = _orderDataController.Get();
            //evaluate
            if (foundOrders != null)
            {
                if (foundOrders.Count > 0)
                {
                    foundReturn = Ok(foundOrders); //OK found list statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); //OK found list but no content 204
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500); //Internal server error   
            }
            return foundReturn; //send return to client
        }


        // URL: api/orders/{id}
        [HttpGet, Route("{orderId}")]
        public ActionResult<OrderDTO> Get(int orderId)
        {
            ActionResult<OrderDTO> foundReturn;
            try
            {
                //Retieve data converted to DTO
                OrderDTO? foundOrdersById = _orderDataController.Get(orderId);

                //Evaluate
                if (foundOrdersById != null)
                {
                    foundReturn = Ok(foundOrdersById); //OK found order by ID statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); // OK not found, no content statuscode 204
                }
            }
            catch
            {
                foundReturn = new StatusCodeResult(500); // Internal server error   
            }
            return foundReturn; // Send return to client
        }

        // URL: api/orders
        [HttpPost]
        public ActionResult<int> PostNewOrder(OrderDTO orderDTO)
        {
            ActionResult<int> foundReturn;
            int insertedId = -1;
            if (orderDTO != null)
            {
                insertedId = _orderDataController.Add(orderDTO);
            }
            // Evaluate
            if (insertedId > 0)
            {
                foundReturn = Ok(insertedId);
            }
            else if (insertedId == 0)
            {
                foundReturn = BadRequest();     // missing input
            }
            else
            {
                foundReturn = new StatusCodeResult(500);    // Internal server error
            }
            return foundReturn;
        }


        //JEG ER IKKE SIKKER PÅ DE FØLGENDE METODER GRRRRRRRRR

        [HttpDelete]
        public ActionResult Delete(int orderId)
        {
            ActionResult foundReturn;
            bool wasOk = _orderDataController.Delete(orderId);
            if (wasOk)
            {
                foundReturn = Ok();
            }
            else
            {
                foundReturn = new StatusCodeResult(500);    // Internal server error
            }
            return foundReturn;
        }

        [HttpPut]
        public ActionResult<bool> Put(OrderDTO orderDTO)
        {
            ActionResult foundReturn;

            WebshopModel.ModelLayer.Order? order = ModelConversion.OrderDTOConversion.ToOrder(orderDTO);

            if (orderDTO != null)
            {
                bool wasOk = _orderDataController.Put(orderDTO);

                if (wasOk)
                {
                    foundReturn = Ok();
                }
                else
                {
                    foundReturn = new StatusCodeResult(500);
                }
            }
            else
            {
                foundReturn = BadRequest();
            }

            return foundReturn;
        }
    }
}
