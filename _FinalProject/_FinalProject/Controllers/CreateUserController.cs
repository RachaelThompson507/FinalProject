using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _FinalProject.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class CreateUserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public CreateUserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
        SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        
        [HttpGet]
        public IActionResult CreateUser()
        {
            var userCreateVM = new CreateUserViewModel();

            return View(userCreateVM);
        }

        [HttpPost]
        [Authorize(Roles ="GeneralUser")]
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
                    //new user
                    await _userManager.AddToRoleAsync(user,"GeneralUser");
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