using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IUsersByRobinRepository
    {
        //Create
        UserByRobin Create(UserByRobin newUser);

        //Read
        UserByRobin GetById(int UserByRobinId);
        ICollection<Robin> GetRobinById(int robinId);
        ICollection<User> GetUserById(string robinId);

        //Update
        UserByRobin Update(UserByRobin updatedUserByRobin);

        //Delete
        bool DeleteById(int userByRobinId);
    }
}
