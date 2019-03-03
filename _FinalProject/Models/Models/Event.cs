using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public enum Attending {maybe = 1, yes = 2, no = 3}
    public class Event
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EventDate { get; set; }
        public bool Attending { get; set; }
        public string EventComment { get; set; }

        //relationships
        public int RobinId { get; set; }
        public string UserId { get; set; }
        public int eventId { get; set; }

         //Navigational References 
         public User User { get; set; }
         public Robin Robin { get; set; }
    }
}
