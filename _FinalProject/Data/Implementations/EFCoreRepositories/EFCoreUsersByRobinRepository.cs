using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreUsersByRobinRepository : IUsersByRobinRepository
    {
        public UsersByRobin Create(UsersByRobin newUser)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int userByRobinId)
        {
            throw new NotImplementedException();
        }

        public UsersByRobin GetById(int UserByRobinId)
        {
            throw new NotImplementedException();
        }

        public ICollection<UsersByRobin> GetRobinById(int robinId)
        {
            throw new NotImplementedException();
        }

        public ICollection<UsersByRobin> GetUserById(string robinId)
        {
            throw new NotImplementedException();
        }

        public UsersByRobin Update(UsersByRobin updatedUserByRobin)
        {
            throw new NotImplementedException();
        }
    }
}
