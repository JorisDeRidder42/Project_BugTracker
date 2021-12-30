using BugTracker.Data;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class IssueController : Controller
    {
        private readonly BugTrackerContext _context;

        public IssueController(BugTrackerContext context)
        {
            _context = context;
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(CreateBugViewModel viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Models.Bugs bugs = new Models.Bugs();
        //        {
        //            bugs.BugsId = viewModel.BugsId;
        //            bugs.BugTitle = viewModel.BugTitle;
        //            bugs.BugDescription = viewModel.BugDescription;
        //        };
        //    }
        //    return View(viewModel);
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}