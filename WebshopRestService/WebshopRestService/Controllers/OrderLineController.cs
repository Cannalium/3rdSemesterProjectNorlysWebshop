using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLineController : ControllerBase
    {
        private readonly IOrderLineData _orderLineDataController;

        // Constructor with Dependency Injection
        public OrderLineController(IOrderLineData orderLineDataController)
        {
            _orderLineDataController = orderLineDataController;
        }

        // URL: api/orderlines
        [HttpGet]
        public ActionResult<List<OrderLineDTO>>? Get()
        {
            ActionResult<List<OrderLineDTO>> foundReturn;
            //Retrieve data converted to DTO
            List<OrderLineDTO>? foundOrderLines = _orderLineDataController.Get();
            //evaluate
            if (foundOrderLines != null)
            {
                if (foundOrderLines.Count > 0)
                {
                    foundReturn = Ok(foundOrderLines); //OK found list status code 200
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
            return foundReturn; //send return to the client
        }

        // URL: api/orderlines/{id}
        [HttpGet, Route("{orderLineId}")]
        public ActionResult<OrderLineDTO> Get(int orderLineId)
        {
            ActionResult<OrderLineDTO> foundReturn;
            try
            {
                //Retrieve data converted to DTO
                OrderLineDTO? foundOrderLineById = _orderLineDataController.Get(orderLineId);

                //Evaluate
                if (foundOrderLineById != null)
                {
                    foundReturn = Ok(foundOrderLineById); //OK found orderline by ID status code 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204); // OK not found, no content status code 204
                }
            }
            catch
            {
                foundReturn = new StatusCodeResult(500); // Internal server error   
            }
            return foundReturn; // Send return to the client
        }

        // URL: api/orderlines
        [HttpPost]
        public ActionResult<int> PostNewOrderLine(OrderLineDTO orderLineDTO)
        {
            ActionResult<int> foundReturn;
            int insertedId = -1;
            if (orderLineDTO != null)
            {
                insertedId = _orderLineDataController.Add(orderLineDTO);
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

        [HttpDelete]
        public ActionResult Delete(int orderLineId)
        {
            ActionResult foundReturn;
            bool wasOk = _orderLineDataController.Delete(orderLineId);
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
        public ActionResult<bool> Put(OrderLineDTO orderLineDTO)
        {
            ActionResult foundReturn;

            WebshopModel.ModelLayer.OrderLine? orderLine = ModelConversion.OrderLineDTOConversion.ToOrderLine(orderLineDTO);

            if (orderLineDTO != null)
            {
                bool wasOk = _orderLineDataController.Put(orderLineDTO);

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
