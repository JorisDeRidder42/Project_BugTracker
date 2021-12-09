using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("User", Schema = "BugTracker")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public int BugID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool? AllowEmailNotification { get; set; }

        public ICollection<ProjectsAcces> ProjectsAcces { get; set; }
        public Bugs Bugs { get; set; }
    }
}