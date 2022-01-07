using BugTracker.Areas.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.ViewModel
{
    public class CreateBugViewModel
    {
        public int BugsId { get; set; }

        [Required]
        public string BugTitle { get; set; }

        [Required]
        public string BugDescription { get; set; }

        public string BugType { get; set; }

        [Required]
        public string BugCreatedBy { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BugCreatedOn { get; set; }

        public string BugClosedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime BugClosedOn { get; set; }
    }
}