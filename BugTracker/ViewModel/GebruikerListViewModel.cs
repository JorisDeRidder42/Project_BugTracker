using BugTracker.Areas.Data;
using BugTracker.Models;
using System.Collections.Generic;

namespace BugTracker.ViewModel
{
    public class GebruikerListViewModel
    {
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}