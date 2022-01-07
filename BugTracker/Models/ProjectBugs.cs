using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("ProjectBugs", Schema = "BugTracker")]
    public class ProjectBugs
    {
        [Key]
        public int ProjectBugsId { get; set; }

        public int ProjectsId { get; set; }
        public int BugsId { get; set; }

        public Bugs Bugs { get; set; }
        public Projects Projects { get; set; }
    }
}