﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _FinalProject.Model.Models
{
    public class Map
    {
        public int Id { get; set; }
       public double Latutude { get; set; }
        public double  Longitute { get; set; }

        //relationships
        public string UserId { get; set; }
        public int RobinId { get; set; }

        //Navigational References 
        public User User { get; set; }
        public Robin Robin { get; set; }
    }
}
