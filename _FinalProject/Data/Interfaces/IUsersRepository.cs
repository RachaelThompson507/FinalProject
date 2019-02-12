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
        User GetById(string UserId);

        //Update
        User Update(User updatedUser);

        //Delete
        bool DeleteById(string userId);
    }
}
