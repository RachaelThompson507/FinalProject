﻿using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IUsersService
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

    public class UsersService : IUsersService
    {
        private readonly IUsersService _userService;

        public UsersService(IUsersService userService) =>
            _userService = userService;

        public User Create(User newUser) =>
            _userService.Create(newUser);

        public bool DeleteById(string userId) =>
            _userService.DeleteById(userId);

        public User GetById(string UserId) =>
            _userService.GetById(UserId);

        public User Update(User updatedUser) =>
            _userService.Update(updatedUser);
    }
}
