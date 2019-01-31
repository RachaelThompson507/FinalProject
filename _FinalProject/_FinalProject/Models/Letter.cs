using System;
namespace _FinalProject.Models
{
    public class Letter
    {
        public int LetterId { get; set; }
        public string Name { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }

        //Relationships
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public int SubmissionId { get; set; }
        public string UserId { get; set; }
        public int RobinId { get; set; }

    }
}
