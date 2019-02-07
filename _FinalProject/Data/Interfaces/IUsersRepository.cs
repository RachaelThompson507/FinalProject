using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    interface IUsersRepository
    {
        //Create
        User Create(User newUser);

        //Read
        User GetById(int UserId);
        ICollection<Robin> GetRobinById(string robinId);

        //Update
        User Update(User updatedUser);

        //Delete
        bool DeleteById(int userId);
    }
}
