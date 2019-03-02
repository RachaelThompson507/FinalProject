using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace _FinalProject.Model.Models
{
    public class User : IdentityUser
    {
        //updated based on the IdentityUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        //location
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        //Navigational References 
        public IEnumerable<Robin>Robins { get; set; }
    }
}
