using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IUsersByRobinService
    {
        //Create
        UsersByRobin Create(UsersByRobin newUser);

        //Read
        UsersByRobin GetById(int UserByRobinId);
        ICollection<UsersByRobin> GetRobinById(int robinId);
        ICollection<UsersByRobin> GetUserById(string userId);

        //Update
        UsersByRobin Update(UsersByRobin updatedUserByRobin);

        //Delete
        bool DeleteById(int userByRobinId);
    }

    public class UsersByRobinService : IUsersByRobinService
    {
        private readonly IUsersByRobinService _usersByRobinService;

        public UsersByRobinService(IUsersByRobinService usersByRobinService) =>
            _usersByRobinService = usersByRobinService;

        public UsersByRobin Create(UsersByRobin newUser) =>
            _usersByRobinService.Create(newUser);

        public bool DeleteById(int userByRobinId) =>
            _usersByRobinService.DeleteById(userByRobinId);

        public UsersByRobin GetById(int UserByRobinId) =>
            _usersByRobinService.GetById(UserByRobinId);

        public ICollection<UsersByRobin> GetRobinById(int robinId) =>
            _usersByRobinService.GetRobinById(robinId);

        public ICollection<UsersByRobin> GetUserById(string userId) =>
            _usersByRobinService.GetUserById(userId);

        public UsersByRobin Update(UsersByRobin updatedUserByRobin) =>
            _usersByRobinService.Update(updatedUserByRobin);
    }
}
