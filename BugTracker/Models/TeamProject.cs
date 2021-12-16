using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TeamProject
    {
        [Key]
        public int TeamProjectID { get; set; }
        public int ProjectID { get; set; }
        public int TeamID { get; set; }

        public Team Team { get; set; }
        public Projects Projects { get; set; }
    }
}
