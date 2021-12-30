using BugTracker.Data;
using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class IssueController : Controller
    {
        //private readonly BugTrackerContext _context;

        //public IssueController(BugTrackerContext context)
        //{
        //    _context = context;
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(CreateBugViewModel viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(new Bugs()
        //        {
        //            BugTitle = viewModel.BugTitle,
        //            BugDescription = viewModel.BugDescription,
        //            BugCreatedOn = viewModel.BugCreatedOn,
        //            BugClosedBy = viewModel.BugClosedBy,
        //            BugCreatedBy = viewModel.BugCreatedBy,
        //        });

        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(viewModel);
        //}

        public IActionResult Create()
        {
            return View();
        }
    }
}