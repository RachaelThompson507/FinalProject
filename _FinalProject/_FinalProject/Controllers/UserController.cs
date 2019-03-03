using System;
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
        //private readonly IdentityRole _role;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
        SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            //_role = _roleManager.Roles.ToList();
        }
        
        [HttpGet]
        public IActionResult CreateUser()
        {
            //only allowing User Role creation here
            var userCreateVM = new CreateUserViewModel
            {
                //Role = _role.NormalizedName("GENERALUSER")
            };

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
                    var id = await _roleManager.FindByIdAsync("1");
                    await _userManager.AddToRoleAsync(user, userCreateVM.Role );
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