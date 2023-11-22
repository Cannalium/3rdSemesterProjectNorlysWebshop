using Microsoft.AspNetCore.Mvc;
using WebshopRestService.BusinessLogicLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonData _personDataController;

        // Constructor with Dependency Injection
        public PersonController(IPersonData personDataController)
        {
            _personDataController = personDataController;
        }

        // URL: api/persons
        [HttpGet]
        public ActionResult<List<PersonDTO>>? Get()
        {
            ActionResult<List<PersonDTO>> foundReturn;
            //Retrieve data converted to DTO
            List<PersonDTO>? foundPersons = _personDataController.Get();
            //evaluate
            if (foundPersons != null)
            {
                if (foundPersons.Count > 0)
                {
                    foundReturn = Ok(foundPersons); //OK found list statuscode 200
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


        // URL: api/persons/{id}
        [HttpGet, Route("{personId}")]
        public ActionResult<PersonDTO> Get(int personId)
        {
            ActionResult<PersonDTO> foundReturn;
            try
            {
                //Retieve data converted to DTO
                PersonDTO? foundPersonsById = _personDataController.Get(personId);

                //Evaluate
                if (foundPersonsById != null)
                {
                    foundReturn = Ok(foundPersonsById); //OK found person by ID statuscode 200
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

        // URL: api/persons
        [HttpPost]
        public ActionResult<int> PostNewPerson(PersonDTO personDTO)
        {
            ActionResult<int> foundReturn;
            int insertedId = -1;
            if (personDTO != null)
            {
                insertedId = _personDataController.Add(personDTO);
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
        public ActionResult Delete(int personId) 
        {
            ActionResult foundReturn;
            bool wasOk = _personDataController.Delete(personId);
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
        public ActionResult<bool> Put(PersonDTO personDTO)
        {
            ActionResult foundReturn;
            
            WebshopModel.ModelLayer.Person? person = ModelConversion.PersonDTOConversion.ToPerson(personDTO);
           
            if (personDTO != null)
            {
                bool wasOk = _personDataController.Put(personDTO);

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
