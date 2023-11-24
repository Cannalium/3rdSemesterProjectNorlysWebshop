using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class PersonController : Controller // er ikke sikker på det der : Controller
    {
        private PersonDataControl _personDataControl;

        public PersonController() 
        {
            _personDataControl = new PersonDataControl();
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            // Get id logged in user
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            // Get customer through service
            Person? personFromService = await _personDataControl.GetPersonByUserId(userId);
            // If customer was not found (but call ok)
            if (personFromService != null && personFromService.UserId == null)
            {
                string? email = User.Identity is not null ? User.Identity.Name : null;
                /* Create customer - and get created customer */
                personFromService = await _personDataControl.CreatePersonFromUserAccount(userId, email);
            }
            return View(personFromService);
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> EditProfile(string id)
        {
            return null;
        }
    }
}
