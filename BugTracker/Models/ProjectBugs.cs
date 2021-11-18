using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ProjectBugs
    {
        [Key]
        public int ProjectBugsID { get; set; }

        public int ProjectsID { get; set; }
        public int BugsID { get; set; }

        public ICollection<Bugs> Bugs { get; set; }
        public ICollection<Projects> Projects { get; set; }
    }
}