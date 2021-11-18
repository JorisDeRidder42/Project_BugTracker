using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ProjectsAcces
    {
        [Key]
        public int ProjectAccesID { get; set; }

        public int ProjectsID { get; set; }

        public int UserID { get; set; }

        public ICollection<Projects> Projects { get; set; }
        public ICollection<User> User { get; set; }
    }
}