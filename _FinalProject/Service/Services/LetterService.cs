using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface ILetterService
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

    public class LetterService : ILetterService
    {
        private readonly ILetterService _letterService;

        public LetterService(ILetterService letterService) =>
            _letterService = letterService;

        public Letter Create(Letter newLetter) =>
            _letterService.Create(newLetter);

        public bool DeleteById(int letterId) =>
            _letterService.DeleteById(letterId);

        public Letter GetById(int letterId) =>
            _letterService.GetById(letterId);

        public ICollection<Letter> GetRobinById(int robinId) =>
            _letterService.GetRobinById(robinId);

        public ICollection<Letter> GetUserById(string userId) =>
            _letterService.GetUserById(userId);

        public Letter Update(Letter updatedLetter) =>
            _letterService.Update(updatedLetter);
    }
}
