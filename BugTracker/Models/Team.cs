using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    [Table("Teams", Schema = "BugTracker")]
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamNaam { get; set; }
        public int AantalPersonen { get; set; }
        public User User { get; set; }
    }
}
