using System;

namespace BugTracker.ViewModel
{
    public class CreateBugViewModel
    {
        public int BugsId { get; set; }
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public string BugType { get; set; }
        public string BugCreatedBy { get; set; }
        public DateTime BugCreatedOn { get; set; }
        public string BugClosedBy { get; set; }
        public DateTime BugClosedOn { get; set; }
    }
}