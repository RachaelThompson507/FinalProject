using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockUserRepository : IUsersRepository
    {
        private List<User> Users = new List<User>();
        public User Create(User newUser)
        {
            newUser.Id = Users.OrderByDescending(c => c.Id).Single().Id + 1;
            return newUser;
        }

        public bool DeleteById(string userId)
        {
            var user = GetById(userId);
            Users.Remove(user);
            return true;
        }

        public User GetById(string UserId)
        {
            return Users.Single(c => c.Id == UserId);
        }

        public User Update(User updatedUser)
        {
            DeleteById(updatedUser.Id);
            Users.Add(updatedUser);
            return updatedUser;
        }
    }
}
