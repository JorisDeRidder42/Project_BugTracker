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
        public List<Bugs> bugs;

        [Authorize]
        public IActionResult Index()
        {
            OverzichtBugsViewModel viewModel = new OverzichtBugsViewModel();
            {
                viewModel.Bugs = bugs;
            }
            return View(viewModel);
        }
    }
}