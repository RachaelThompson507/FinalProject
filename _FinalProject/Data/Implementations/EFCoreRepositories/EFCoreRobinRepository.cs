using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreRobinRepository : IRobinRepository
    {
        public Robin Create(Robin newRobin)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Robins.Add(newRobin);
                db.SaveChanges();
                return newRobin;
            }
        }

        public bool DeleteById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robin = GetById(robinId);
                db.Robins.Remove(robin);
                db.SaveChanges();
                return true;
            }
        }

        public Robin GetById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Robins.Single(r => r.Id == robinId);
            }
        }

        public Robin Update(Robin updatedRobin)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedRobin.Id);
                db.Entry(update).CurrentValues.SetValues(updatedRobin);
                db.SaveChanges();
                return update;
            }
        }
    }
}
