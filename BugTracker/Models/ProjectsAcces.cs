using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("ProjectsAcces", Schema = "BugTracker")]
    public class ProjectsAcces
    {
        [Key]
        public int ProjectAccesID { get; set; }

        public int ProjectsID { get; set; }

        public int UserID { get; set; }

        public Projects Projects { get; set; }
        public User User { get; set; }
    }
}