using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class BugStatus
    {
        [Key]
        public int BugStatusID { get; set; }

        public string BugStatusType { get; set; }
    }
}