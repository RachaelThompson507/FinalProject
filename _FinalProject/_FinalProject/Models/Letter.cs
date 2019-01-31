using System;
namespace _FinalProject.Models
{
    public class Letter
    {
        public int LetterID { get; set; }
        public string Name { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }

        //Relationships
        public int PostID { get; set; }
        public int CommentID { get; set; }
        public int SubmissionStatus { get; set; }
        public string UserIdSubmitted { get; set; }
        public string UserIdAdminCreated { get; set; }
        public int RobinId { get; set; }

    }
}
