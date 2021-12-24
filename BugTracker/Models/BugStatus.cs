using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    [Table("BugStatus", Schema = "BugTracker")]
    public class BugStatus
    {
        [Key]
        public int BugStatusId { get; set; }

        public string BugStatusType { get; set; }

        public ICollection<Bugs> Bugs { get; set; }
    }
}