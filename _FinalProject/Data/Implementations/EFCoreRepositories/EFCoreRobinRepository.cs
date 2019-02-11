using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreRobinRepository : IRobinRepository
    {
        public Robin Create(Robin newRobin)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int robinId)
        {
            throw new NotImplementedException();
        }

        public Robin GetById(int robinId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Robin> GetUserById(string userId)
        {
            throw new NotImplementedException();
        }

        public Robin Update(Robin updatedRobin)
        {
            throw new NotImplementedException();
        }
    }
}
