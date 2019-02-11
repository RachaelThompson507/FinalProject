using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
   public interface IRobinRepository
    {
        //Create
        Robin Create(Robin newRobin);

        //Read
        Robin GetById(int robinId);
        ICollection<Robin> GetUserById(string userId);

        //Update
        Robin Update(Robin updatedRobin);

        //Delete
        bool DeleteById(int robinId);
    }
}
