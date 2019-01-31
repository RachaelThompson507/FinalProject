using System;
namespace _FinalProject.Models
{
    public class UsersByRobin
    {
        //Relationships
        public string UserID { get; set; }
        public int RobinID { get; set; }

        //unique attributes
        public bool Admin { get; set; }

    }
}
