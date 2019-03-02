using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class CreateUserViewModel
    {
        [EmailAddress, Required]
        public string Email { get; set; }

        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        
        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Password Fields Do Not Match"), Required]
        public string ConfirmPassword { get; set; }

        [Required, Display(Description =("First Name"))]
        public string FirstName { get; set; }

        [Required, Display(Description = ("Last Name"))]
        public string LastName { get; set; }
    }
}
