﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _FinalProject.Model.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        //relationships
        public string UserId { get; set; }
        public int RobinId { get; set; }

        //Navigational References 
        public User User { get; set; }
        public Robin Robin { get; set; }
    }
}
