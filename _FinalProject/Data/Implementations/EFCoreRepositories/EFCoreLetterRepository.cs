using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreLetterRepository : ILetterRepository
    {
        public Letter Create(Letter newLetter)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Letters.Add(newLetter);
                db.SaveChanges();
                return newLetter;
            }
        }

        public bool DeleteById(int letterId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var letter = GetById(letterId);
                db.Letters.Remove(letter);
                db.SaveChanges();
                return true;
            }
        }

        public Letter GetById(int letterId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Letters.Single(l => l.Id == letterId);
            }
        }

        public ICollection<Letter> GetRobinById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robinLetter = db.Letters.Where(c => c.RobinId == robinId).ToList() as ICollection<Letter>;
                return robinLetter;
            }
        }

        public ICollection<Letter> GetUserById(string userId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var userLetter = db.Letters.Where(c => c.UserId == userId).ToList() as ICollection<Letter>;
                return userLetter;
            }
        }

        public Letter Update(Letter updatedLetter)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedLetter.Id);
                db.Entry(update).CurrentValues.SetValues(updatedLetter);
                db.SaveChanges();
                return update;
            }
        }
    }
}
