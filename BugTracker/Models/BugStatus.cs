using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("BugsStatus", Schema = "BugTracker")]
    public class BugStatus
    {
        [Key]
        public int BugStatusID { get; set; }

        public string BugStatusType { get; set; }

        public ICollection<Bugs> Bugs { get; set; }
    }
}