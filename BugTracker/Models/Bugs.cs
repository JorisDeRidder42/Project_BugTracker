using BugTracker.Areas.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("Bugs", Schema = "BugTracker")]
    public class Bugs
    {
        [Key]
        public int BugsId { get; set; }

        public int ApplicationId { get; set; }

        public int? BugsPriorityId { get; set; }

        public int BugStatusId { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the title of the bug")]
        public string BugTitle { get; set; }

        [Required(ErrorMessage = "Please enter the description of the bug")]
        public string BugDescription { get; set; }

        [Required(ErrorMessage = "Please select the type of the bug")]
        public string BugType { get; set; }

        [Required(ErrorMessage = "Please enter who created the bug")]
        public string BugCreatedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime BugCreatedOn { get; set; }

        public string BugClosedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BugClosedOn { get; set; }

        public ICollection<ProjectBugs> ProjectBugs { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public BugStatus BugStatus { get; set; }
        public BugsPriority BugsPriority { get; set; }
    }
}