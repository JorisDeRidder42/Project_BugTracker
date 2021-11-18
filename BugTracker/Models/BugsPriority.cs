using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class BugsPriority
    {
        [Key]
        public int BugsPriorityID { get; set; }

        public string PriorityType { get; set; }
    }
}