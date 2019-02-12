using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{ 
    public class MockUsersByRobinRepository : IUsersByRobinRepository
    {
        private List<UsersByRobin> UserByRobins = new List<UsersByRobin>();
        public UsersByRobin Create(UsersByRobin newUser)
        {
            newUser.Id = UserByRobins.OrderByDescending(c => c.Id).Single().Id + 1;
            return newUser;
        }

        public bool DeleteById(int userByRobinId)
        {
            var user = GetById(userByRobinId);
            UserByRobins.Remove(user);
            return true;
        }

        public UsersByRobin GetById(int UserByRobinId)
        {
            return UserByRobins.Single(c => c.Id == UserByRobinId);
        }

        public ICollection<UsersByRobin> GetRobinById(int robinId)
        {
            return UserByRobins.FindAll(c => c.RobinId == robinId);
        }

        public ICollection<UsersByRobin> GetUserById(string userId)
        {
            return UserByRobins.FindAll(c => c.UserId == userId);
        }

        public UsersByRobin Update(UsersByRobin updatedUserByRobin)
        {
            DeleteById(updatedUserByRobin.Id);
            UserByRobins.Add(updatedUserByRobin);
            return updatedUserByRobin;
        }
    }
}
