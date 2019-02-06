using System;
using System.Collections.Generic;

namespace _FinalProject.Model.Models
{
    public class User
    {
        
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DisableDate { get; set; }

        //Relationships

        //Navigational References 
        public IEnumerable<Robin>Robins { get; set; }
    }
}
