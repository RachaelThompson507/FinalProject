using System;
namespace _FinalProject.Model.Models
{ 
    public class UsersByRobin
    {
        public int Id { get; set; }
        //unique attributes
        public bool Admin { get; set; }
        //Relationships
        public string UserId { get; set; }
        public int RobinID { get; set; }
        //Navigational References 
        public User User { get; set; }
        public Robin Robin { get; set; }
    }
}
