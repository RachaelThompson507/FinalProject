using System;
using System.Collections.Generic;

namespace _FinalProject.Model.Models
{
    public class SubmissionStatus
    {
        public int Id { get; set; }
        //attributes
        public string SubmissionState { get; set; }

        //relationships
     

        //Navigational References 
        IEnumerable<User>Users { get; set; }
    }
}
