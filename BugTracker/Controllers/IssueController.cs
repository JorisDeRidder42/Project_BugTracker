using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
