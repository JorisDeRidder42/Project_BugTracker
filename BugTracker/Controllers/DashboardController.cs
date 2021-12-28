using BugTracker.Data;
using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        //[Authorize]
        public IActionResult Index()
        {
            OverzichtBugsViewModel viewModel = new OverzichtBugsViewModel();
            {
                viewModel.Bugs = _context.Bugs.ToList();
            }
            return View(viewModel);
        }
    }
}