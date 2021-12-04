using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("Bugs", Schema = "BugTracker")]
    public class Bugs
    {
        [Key]
        public int BugsID { get; set; }

        public int BugsPriorityID { get; set; }

        public int BugStatusID { get; set; }

        [Required]
        public string BugTitle { get; set; }

        [Required]
        public string BugDescription { get; set; }

        [Required]
        public string BugType { get; set; }

        [Required]
        public User BugCreatedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime BugCreatedOn { get; set; }

        public User BugClosedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime BugClosedOn { get; set; }

        public ICollection<ProjectBugs> ProjectBugs { get; set; }
        public ICollection<User> Users { get; set; }
        public BugStatus BugStatus { get; set; }
        public BugsPriority BugsPriority { get; set; }
    }
}