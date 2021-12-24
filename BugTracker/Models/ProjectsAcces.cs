using BugTracker.Areas.Data;
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
        public int ProjectAccesId { get; set; }

        public int ProjectsId { get; set; }

        public int ApplicationId { get; set; }

        public Projects Projects { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}