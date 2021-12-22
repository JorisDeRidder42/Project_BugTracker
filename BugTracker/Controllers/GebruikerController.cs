using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BugTracker.Controllers
{
    public class GebruikerController : Controller
    {
        private UserManager<User> _gebruikerManager;

        public GebruikerController(UserManager<User> userManager)
        {
            _gebruikerManager = userManager;
        }

        public IActionResult Index()
        {
            GebruikerListViewModel gviewModel = new GebruikerListViewModel()
            {
                Gebruikers = _gebruikerManager.Users.ToList()
            };
            return View(gviewModel);
        }
    }
}