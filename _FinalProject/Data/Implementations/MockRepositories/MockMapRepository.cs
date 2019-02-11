using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockMapRepository : IMapRepository
    {
        public Map Create(Map newMap)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int mapId)
        {
            throw new NotImplementedException();
        }

        public Map GetById(int mapId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Map> GetRobinById(int robinId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Map> GetUserById(string userId)
        {
            throw new NotImplementedException();
        }

        public Map Update(Map updatedMap)
        {
            throw new NotImplementedException();
        }
    }
}
