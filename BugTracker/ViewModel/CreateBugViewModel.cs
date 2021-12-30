using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.ViewModel
{
    public class CreateBugViewModel
    {
        public int BugsId { get; set; }
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public string BugStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime BugCreatedOn { get; set; }

        public string BugClosedBy { get; set; }

        public string BugCreatedBy { get; set; }
    }
}