using System;
using System.Collections.Generic;

namespace _FinalProject.Model.Models
{
    public class Letter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }

        //Relationships
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public int SubmissionId { get; set; }
        //needs to be userId of Admin that approved request
        public string UserId { get; set; }
        public int RobinId { get; set; }

        //Navigational References 
        public User User { get; set; }
        public Robin Robin { get; set; }
        public IEnumerable<Post>Posts { get; set; }
        public IEnumerable<Comment>Comments { get; set; }
        public IEnumerable<SubmissionStatus>SubmissionStatuses { get; set; }
    }
}
