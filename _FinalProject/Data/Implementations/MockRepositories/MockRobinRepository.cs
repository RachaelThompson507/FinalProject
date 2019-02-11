using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockRobinRepository : IRobinRepository
    {
        private List<Robin> Robins = new List<Robin>();
        public Robin Create(Robin newRobin)
        {
            newRobin.Id = Robins.OrderByDescending(c => c.Id).Single().Id + 1;
            return newRobin;
        }

        public bool DeleteById(int robinId)
        {
            var robin = GetById(robinId);
            Robins.Remove(robin);
            return true;
        }

        public Robin GetById(int robinId)
        {
            return Robins.Single(r=> r.Id == robinId);
        }

        public Robin Update(Robin updatedRobin)
        {
            DeleteById(updatedRobin.Id);
            Robins.Add(updatedRobin);
            return updatedRobin;
        }
    }
}
