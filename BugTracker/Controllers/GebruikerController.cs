using BugTracker.Areas.Data;
using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BugTracker.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "admin")]
    public class GebruikerController : Controller
    {
        private UserManager<ApplicationUser> _userManager;

        public GebruikerController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            OverzichtGebruikersViewModel gviewModel = new OverzichtGebruikersViewModel()
            {
                Users = _userManager.Users.ToList()
            };
            return View(gviewModel);
        }

        public IActionResult Toevoegen()
        {
            return View();
        }
    }
}