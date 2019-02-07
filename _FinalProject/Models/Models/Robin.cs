using System;
using System.Collections.Generic;

namespace _FinalProject.Model.Models
{
    public class Robin
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string InviteCode { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime DisableDate { get; set; }

        //Relationships

        //Navigational References 
        public IEnumerable<Letter> Letters { get; set; }
    }
}
