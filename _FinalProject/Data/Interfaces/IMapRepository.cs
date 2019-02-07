using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    interface IMapRepository
    {
        //Create
        Map Create(Map newMap);

        //Read
        Map GetById(int mapId);
        ICollection<User> GetUserById(string userId);
        ICollection<Robin> GetRobinById(int robinId);

        //Update
        Map Update(Map updatedMap);

        //Delete
        bool DeleteById(int mapId);
    }
}
