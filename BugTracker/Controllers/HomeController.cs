using BugTracker.Data;
using BugTracker.Models;
using BugTracker.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly BugTrackerContext _context;

        public HomeController(BugTrackerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //OverzichtBugsViewModel viewModel = new OverzichtBugsViewModel();
            //return viewModel();
            return View();
        }

        public IActionResult User()
        {
            List<User> users = new List<User>();

            users.Add(new User() { UserID = 1, FirstName = "Joris", LastName = "De Ridder", UserName = "Heufd", allowEmailNotification = true, Email = "Joris.42@hotmail.com", GeboorteDatum = new System.DateTime(1997, 02, 21), Password = "Meloen" }); ;
            users.Add(new User() { UserID = 2, FirstName = "Alec", LastName = "Van Oosterwick", UserName = "Tankzwaluw", allowEmailNotification = true, Email = "VanOosterwijckAlec@gmail.com", GeboorteDatum = new System.DateTime(2002, 10, 11), Password = "DikkeJood123" }); ;
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}