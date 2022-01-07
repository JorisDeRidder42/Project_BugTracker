using BugTracker.Areas.Data;
using BugTracker.Models;
using System.Collections.Generic;

namespace BugTracker.ViewModel
{
    public class OverzichtGebruikersViewModel
    {
        public List<ApplicationUser> Users { get; set; }
    }
}