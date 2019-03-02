﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _FinalProject.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
        SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        
        [HttpGet]
        public IActionResult CreateUser()
        {
            //only allowing User Role creation here
            var userCreateVM = new CreateUserViewModel();
            return View(userCreateVM);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel userCreateVM)
        {
            if(ModelState.IsValid)
            {
                var user = new User
                {
                    //Create User
                    Email = userCreateVM.Email,
                    UserName = userCreateVM.Email,
                    FirstName = userCreateVM.FirstName,
                    LastName = userCreateVM.LastName
                };

                var result = await _userManager.CreateAsync(user, userCreateVM.Password);

                if(result.Succeeded)
                {
                    //new user - apply role
                    await _userManager.AddToRoleAsync(user, userCreateVM.Role.Id = 1.ToString());
                    //auto - login user
                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            };
            return View(userCreateVM);
        }
    }
}