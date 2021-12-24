using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TeamProject
    {
        [Key]
        public int TeamProjectId { get; set; }

        public int ProjectId { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        public Projects Projects { get; set; }
    }
}