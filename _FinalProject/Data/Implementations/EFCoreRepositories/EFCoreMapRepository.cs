using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreMapRepository : IMapRepository
    {
        public Map Create(Map newMap)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Maps.Add(newMap);
                db.SaveChanges();
                return newMap;
            }
        }

        public bool DeleteById(int mapId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var map = GetById(mapId);
                db.Maps.Remove(map);
                db.SaveChanges();
                return true;
            }
        }

        public Map GetById(int mapId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Maps.Single(m => m.Id == mapId);
            }
        }

        public ICollection<Map> GetRobinById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robinMap = db.Maps.Where(c => c.RobinId == robinId).ToList() as ICollection<Map>;
                return robinMap;
            }
        }

        public ICollection<Map> GetUserById(string userId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var userMap = db.Maps.Where(c => c.UserId == userId).ToList() as ICollection<Map>;
                return userMap;
            }
        }

        public Map Update(Map updatedMap)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedMap.Id);
                db.Entry(update).CurrentValues.SetValues(updatedMap);
                db.SaveChanges();
                return update;
            }
        }
    }
}
