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
        ICollection<Map> GetUserById(string userId);
        ICollection<Map> GetRobinById(int robinId);

        //Update
        Map Update(Map updatedMap);

        //Delete
        bool DeleteById(int mapId);
    }
}
