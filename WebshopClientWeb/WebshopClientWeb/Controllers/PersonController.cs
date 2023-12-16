using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Controllers
{
    public class PersonController : Controller 
    {
        private PersonDataControl _personDataControl;

        public PersonController() 
        {
            _personDataControl = new PersonDataControl();
        }

        // Displays the user profile page, retrieving the logged-in user's information from the provided email
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            // Get id logged in user
            string? email = HttpContext.User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
            {
                // If email is not available
                return RedirectToAction("Error", "Home");
            }
            // Get person through service
            Person? personFromService = await _personDataControl.GetPersonByEmail(email);

            if (personFromService == null)
            {
                // Person not found
                return RedirectToAction("NotFound","Home");
            }
            return View(personFromService);
        }
    }
}
