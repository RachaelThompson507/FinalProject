using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IUsersByRobinRepository
    {
        //Create
        UsersByRobin Create(UsersByRobin newUser);

        //Read
        UsersByRobin GetById(int UserByRobinId);
        ICollection<UsersByRobin> GetRobinById(int robinId);
        ICollection<UsersByRobin> GetUserById(string robinId);

        //Update
        UsersByRobin Update(UsersByRobin updatedUserByRobin);

        //Delete
        bool DeleteById(int userByRobinId);
    }
}
