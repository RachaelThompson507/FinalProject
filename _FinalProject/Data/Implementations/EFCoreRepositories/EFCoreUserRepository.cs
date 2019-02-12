using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreUserRepository : IUsersRepository
    {
        public User Create(User newUser)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return newUser;
            }
        }

        public bool DeleteById(string userId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var user = GetById(userId);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
        }

        public User GetById(string UserId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Users.Single(c => c.Id == UserId);
            }
        }

        public User Update(User updatedUser)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedUser.Id);
                db.Entry(update).CurrentValues.SetValues(updatedUser);
                db.SaveChanges();
                return update;
            }
        }
    }
}
