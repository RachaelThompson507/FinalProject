using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockLetterRepository : ILetterRepository
    {
        private List<Letter> Letters = new List<Letter>();
        public Letter Create(Letter newLetter)
        {
            newLetter.Id = Letters.OrderByDescending(l => l.Id).Single().Id + 1;
            return newLetter;
        }

        public bool DeleteById(int letterId)
        {
            var letter = GetById(letterId);
            Letters.Remove(letter);
            return true;
        }

        public Letter GetById(int letterId)
        {
            return Letters.Single(l => l.Id == letterId);
        }

        public ICollection<Letter> GetRobinById(int robinId)
        {
            return Letters.FindAll(l => l.RobinId == robinId);
        }

        public ICollection<Letter> GetUserById(string userId)
        {
            return Letters.FindAll(l => l.UserId == userId);
        }

        public Letter Update(Letter updatedLetter)
        {
            DeleteById(updatedLetter.Id);
            Letters.Add(updatedLetter);
            return updatedLetter;
        }
    }
}
