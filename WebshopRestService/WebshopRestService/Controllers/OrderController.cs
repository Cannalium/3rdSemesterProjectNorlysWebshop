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

        // Handles the creation of an order based on the provided OrderDTOWrite, returning appropriate HTTP status codes
        [HttpPost]
        public ActionResult<int> CreateOrder(OrderDTOWrite orderDTOWrite)
        {
            if (orderDTOWrite == null)
            {
                return BadRequest(); // 400
            }

            int insertedId = _orderDataController.CreateOrder(orderDTOWrite);

            if (insertedId > 0)
            {
                return Ok(insertedId); // 200
            }
            else if (insertedId == 0)
            {
                return BadRequest(); // missing input
            }
            else if (insertedId == -2)
            {
                return NotFound(); // 404
            }
            else if (insertedId == -3)
            {
                return Conflict(); // 409
            }
            else
            {
                return StatusCode(500); // Internal server error
            }
        }
    }
}

