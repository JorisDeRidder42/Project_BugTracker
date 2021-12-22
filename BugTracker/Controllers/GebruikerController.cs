using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class GebruikerController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}