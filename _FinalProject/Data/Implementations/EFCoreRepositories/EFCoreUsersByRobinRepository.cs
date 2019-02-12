using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreUsersByRobinRepository : IUsersByRobinRepository
    {
        public UsersByRobin Create(UsersByRobin newUser)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.UsersByRobins.Add(newUser);
                db.SaveChanges();
                return newUser;
            }
        }

        public bool DeleteById(int userByRobinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var usersBy = GetById(userByRobinId);
                db.UsersByRobins.Remove(usersBy);
                db.SaveChanges();
                return true;
            }
        }

        public UsersByRobin GetById(int UserByRobinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.UsersByRobins.Single(uR => uR.Id == UserByRobinId);
            }
        }

        public ICollection<UsersByRobin> GetRobinById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robin = db.UsersByRobins.Where(c => c.RobinId == robinId).ToList() as ICollection<UsersByRobin>;
                return robin;
            }
        }

        public ICollection<UsersByRobin> GetUserById(string userId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var user = db.UsersByRobins.Where(c => c.UserId == userId).ToList() as ICollection<UsersByRobin>;
                return user;
            }
        }

        public UsersByRobin Update(UsersByRobin updatedUserByRobin)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedUserByRobin.Id);
                db.Entry(update).CurrentValues.SetValues(updatedUserByRobin);
                db.SaveChanges();
                return update;
            }
        }
    }
}
