using System;
namespace _FinalProject.Models
{
    public class SubmissionStatus
    {
        public int Id { get; set; }
        //attributes
        public string SubmissionState { get; set; }

        //relationships
        public string UserId { get; set; }

    }
}
