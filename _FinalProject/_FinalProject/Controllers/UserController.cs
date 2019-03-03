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
        private readonly List<IdentityRole> _roles;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;

            //call Role Table one time
            _roles = _roleManager.Roles.ToList();
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInViewModel LvM)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(LvM.Email, LvM.Password, LvM.RememberMe, false);

                if (result.Succeeded)
                {
                    //get the User
                    var user = await _userManager.FindByEmailAsync(LvM.Email);

                    //What Role?
                    var isUser = await _userManager.IsInRoleAsync(user, "GeneralUser");

                    //Redirect to the right Controller(based on Role)
                     if (isUser)
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("SignIn", "Username or Password is Invalid");
                }
            }
            return View(LvM);
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}