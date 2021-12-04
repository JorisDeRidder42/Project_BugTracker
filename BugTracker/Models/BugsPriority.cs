using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("BugsPriority", Schema = "BugTracker")]
    public class BugsPriority
    {
        [Key]
        public int BugsPriorityID { get; set; }

        public string PriorityType { get; set; }
        public Bugs Bugs { get; set; }
    }
}