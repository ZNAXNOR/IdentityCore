using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace IdentityCore.ViewModels
{
    public class RegisterViewModel
    {
        //Email
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //Username
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        //Password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //Confirm Password
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //Return Url
        public string? ReturnUrl { get; set; }

        //Roles
        public IEnumerable<SelectListItem>? RoleList { get; set; }
        public string? RoleSelected { get; set; }
    }
}
