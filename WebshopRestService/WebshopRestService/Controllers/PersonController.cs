using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonData _personDataControl;
        private readonly IConfiguration _configuration;

        // Constructor with Dependency Injection
        public PersonController(IConfiguration configuration)
        {
            _configuration = configuration;
            _personDataControl = new PersonDataControl(_configuration);
        }

        // Retrieves a person based on the provided email using PersonDataControl, returning appropriate HTTP status codes
        [HttpGet, Route("{email}")]
        public ActionResult<PersonDTORead?> GetPersonByEmail(string email)
        {
            ActionResult<PersonDTORead?> foundReturn;
            PersonDTORead? foundPerson = _personDataControl.GetPersonByEmail(email);

            // Evaluate retrieved data to determine the appropriate HTTP status code for the response
            if (foundPerson != null)
            {
                if (!String.IsNullOrEmpty(foundPerson.Email))
                {
                    foundReturn = Ok(foundPerson);      // Found - Statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204);    // Ok, but no content - Statuscode 204
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500);    // Internal server error - Statuscode 500
            }

            // Send response back to client
            return foundReturn;
        }
    }
}
