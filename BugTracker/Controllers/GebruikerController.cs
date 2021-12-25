using BugTracker.Areas.Data;
using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BugTracker.Controllers
{
    //[Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class GebruikerController : Controller
    {
        private UserManager<ApplicationUser> _gebruikerManager;

        public GebruikerController(UserManager<ApplicationUser> userManager)
        {
            _gebruikerManager = userManager;
        }

        public IActionResult Index()
        {
            GebruikerListViewModel gviewModel = new GebruikerListViewModel()
            {
                ApplicationUsers = _gebruikerManager.Users.ToList()
            };
            return View(gviewModel);
        }

        public IActionResult Toevoegen()
        {
            return View();
        }
    }
}