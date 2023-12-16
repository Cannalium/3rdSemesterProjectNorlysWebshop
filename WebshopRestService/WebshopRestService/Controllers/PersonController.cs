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
    
        [HttpGet, Route("{email}")]
        public ActionResult<PersonDTORead?> GetPersonByEmail(string email)
        {
            ActionResult<PersonDTORead?> foundReturn;

            // Retrieve and convert data
            PersonDTORead? foundPerson = _personDataControl.GetPersonByEmail(email);

            // Evaluate
            if (foundPerson != null)
            {
                if (!String.IsNullOrEmpty(foundPerson.Email))
                {
                    foundReturn = Ok(foundPerson);                 // Found - Statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204);    // Ok, but no content - Statuscode 204
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500);        // Internal server error - Statuscode 500
            }

            // send response back to client
            return foundReturn;
        }
    }
}
