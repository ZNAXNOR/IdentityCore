using System.ComponentModel.DataAnnotations;

namespace IdentityCore.ViewModels
{
    public class ResetPasswordViewModel
    {
        // Email
        [Required]
        [EmailAddress]
        [Display (Name = "Email")]
        public string Email { get; set; }

        // Password
        [Required]
        [DataType (DataType.Password)]
        [Display (Name = "Password")]
        public string Password { get; set; }

        // Confirm Password
        [Required]
        [DataType (DataType.Password)]
        [Display (Name = "Confirm Password")]
        [Compare ("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }

        // Code
        public string Code { get; set; }
    }
}
