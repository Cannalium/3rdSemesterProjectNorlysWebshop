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
        public ActionResult<List<OrderDTORead>>? Get()
        {
            ActionResult<List<OrderDTORead>> foundReturn;
            //Retrieve data converted to DTO
            List<OrderDTORead>? foundOrders = _orderDataController.Get();
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
        public ActionResult<OrderDTORead> Get(int orderId)
        {
            ActionResult<OrderDTORead> foundReturn;
            try
            {
                //Retieve data converted to DTO
                OrderDTORead? foundOrdersById = _orderDataController.Get(orderId);

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

        [HttpPost]
        public ActionResult<int> PostNewOrder([FromBody] OrderDTOWrite orderDTOWrite)
        {
            if (orderDTOWrite == null)
            {
                return BadRequest();
            }

            int insertedId = _orderDataController.Add(orderDTOWrite);

            if (insertedId > 0)
            {
                return Ok(insertedId);
            }
            else if (insertedId == 0)
            {
                return BadRequest(); // missing input
            }
            else
            {
                return StatusCode(500); // Internal server error
            }
        }


        // URL: api/orders
        /* [HttpPost]
         public ActionResult<int> PostNewOrder(OrderDTOWrite orderDataCreateDTO)
         {
             ActionResult<int> foundReturn;
             int insertedId = -1;
             if (orderDataCreateDTO != null)
             {
                 insertedId = _orderDataController.Add(orderDataCreateDTO);
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
         }*/


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
        public ActionResult<bool> Put(OrderDTOWrite orderDTO)
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

