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
        public int BugsPriorityId { get; set; }

        public string PriorityType { get; set; }
        public ICollection<Bugs> Bugs { get; set; }
    }
}