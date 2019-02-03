using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _FinalProject.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        //relationships
        public string UserId { get; set; }
        public int RobinId { get; set; }
    }
}
