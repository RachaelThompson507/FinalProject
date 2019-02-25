using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _FinalProject.Model.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        //relationships
        public int RobinId { get; set; }
        public string UserId { get; set; }

        //Navigational References 
        public User User { get; set; }
        public Robin Robin { get; set; }

    }
}
