using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockUserRepository : IUsersRepository
    {
        public User Create(User newUser)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetById(int UserId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Robin> GetRobinById(string robinId)
        {
            throw new NotImplementedException();
        }

        public User Update(User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
