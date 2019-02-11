using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockMapRepository : IMapRepository
    {
        private List<Map> Maps = new List<Map>();
        public Map Create(Map newMap)
        {
            newMap.Id = Maps.OrderByDescending(c => c.Id).Single().Id + 1;
            return newMap;
        }

        public bool DeleteById(int mapId)
        {
            var map = GetById(mapId);
            Maps.Remove(map);
            return true;
        }

        public Map GetById(int mapId)
        {
            return Maps.Single(m => m.Id == mapId);
        }

        public ICollection<Map> GetRobinById(int robinId)
        {
            return Maps.FindAll(m => m.RobinId == robinId);
        }

        public ICollection<Map> GetUserById(string userId)
        {
            return Maps.FindAll(m => m.UserId == userId);
        }

        public Map Update(Map updatedMap)
        {
            DeleteById(updatedMap.Id);
            Maps.Add(updatedMap);
            return updatedMap;
        }
    }
}
