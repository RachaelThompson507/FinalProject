using System;
namespace _FinalProject.Models
{
    public class SubmissionStatus
    {
        public int SubmissionId { get; set; }

        //relationships
        public string UserId { get; set; }

        //attributes
        public string SubmissionState { get; set; }
    }
}
