using BugTracker.Data;
using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly BugTrackerContext _context;

        public DashboardController(BugTrackerContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            OverzichtBugsViewModel viewModel = new OverzichtBugsViewModel();
            viewModel.Bugs = _context.Bugs.ToList();
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBugViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Bugs bugs = new Bugs
                {
                    BugsId = viewModel.BugsId,
                    BugTitle = viewModel.BugTitle,
                    BugDescription = viewModel.BugDescription,
                    BugType = viewModel.BugType,
                    BugCreatedBy = viewModel.BugCreatedBy,
                    BugClosedBy = viewModel.BugClosedBy,
                    BugClosedOn = viewModel.BugClosedOn,
                };
                _context.Add(bugs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
}