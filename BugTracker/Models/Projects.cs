using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Projects
    {
        [Key]
        public int ProjectsID { get; set; }

        public string ProjectName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        public string Status { get; set; }

        public string Description { get; set; }

        public ProjectsAcces ProjectsAcces { get; set; }
    }
}