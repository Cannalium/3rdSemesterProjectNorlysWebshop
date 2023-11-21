using Microsoft.AspNetCore.Mvc;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;


namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonData _businessLogicCtrl;

        // Constructor with Dependency Injection
        public PersonController(IPersonData businessLogicCtrl)
        {
            _businessLogicCtrl = businessLogicCtrl;
        }

        // URL: api/persons
        [HttpGet]
        public ActionResult<List<PersonDTO>> Get()
        {
            return null;
        }

        // URL: api/persons/{id}
        [HttpGet, Route("{id}")]
        public ActionResult<PersonDTO> Get(int id)
        {
            return null;
        }

        // URL: api/persons
        [HttpPost]
        public ActionResult PostNewPerson(PersonDTO inPerson)
        {
            return null;
        }


    }
}
