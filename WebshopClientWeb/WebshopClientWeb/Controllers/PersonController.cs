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
            string? email = HttpContext.User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
            {
                // if email is not available
                return RedirectToAction("Error", "Home"); // Redirect to an error page or handle accordingly
            }
            // Get person through service
            Person? personFromService = await _personDataControl.GetPersonByEmail(email);

            if (personFromService == null)
            {
                // Optionally, you might want to handle the case where the person is not found
                return RedirectToAction("NotFound","Home"); // Redirect to a not found page or handle accordingly
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
