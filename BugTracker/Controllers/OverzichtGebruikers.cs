using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class OverzichtGebruikers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}