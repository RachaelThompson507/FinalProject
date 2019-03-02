using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _FinalProject.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult CreateUser()
        {
            //only allowing one role to be created this way
            var userVM = new ViewModels.CreateUserViewModel
            {
                Roles = new Select(_roles)
            };
            return View(userVM);
        }
    }
}