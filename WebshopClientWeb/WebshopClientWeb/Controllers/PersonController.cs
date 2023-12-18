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
            // Get email logged in user
            string? email = HttpContext.User.FindFirstValue(ClaimTypes.Email);

            // Get person through service
            Person? personFromService = await _personDataControl.GetPersonByEmail(email);
            return View(personFromService);
        }
    }
}
