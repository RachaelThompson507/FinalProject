using _FinalProject.Model;
using _FinalProject.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _FinalProject.Data.Context
{
    public class FinalProjectDBContext: DbContext
    {
        public DbSet<User>Users { get; set; }
        public DbSet<Robin>Robins { get; set; }
        public DbSet<UsersByRobin> UsersByRobins { get; set; }
        public DbSet<Letter>Letters { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<SubmissionStatus> SubmissionStatuses { get; set; }
        public DbSet <Calendar>Calendars { get; set; }
        public DbSet<Map>Maps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13; Database=FinalProject; Trusted_Connection=True");
        }
      

    }
}

