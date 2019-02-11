using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    interface ILetterRepository
    {
        //Create
        Letter Create(Letter newLetter);

        //Read
        Letter GetById(int letterId);
        ICollection<Letter> GetUserById(string userId);
        ICollection<Letter> GetRobinById(int robinId);

        //Update
        Letter Update(Letter updatedLetter);

        //Delete
        bool DeleteById(int letterId);
    }
}
