using System;
namespace _FinalProject.Models
{
    public class UsersByRobin
    {
        public int Id { get; set; }
        //unique attributes
        public bool Admin { get; set; }
        //Relationships
        public string UserId { get; set; }
        public int RobinID { get; set; }

    }
}
