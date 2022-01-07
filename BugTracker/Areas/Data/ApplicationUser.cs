using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Areas.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int ApplicationId { get; set; }
        public int BugsId { get; set; }
        public override string UserName { get; set; }
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string Email { get; set; }
        public bool? AllowEmailNotification { get; set; }

        public ICollection<ProjectsAcces> ProjectsAcces { get; set; }
        public ICollection<Bugs> Bugs { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}