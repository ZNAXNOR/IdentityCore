using System.ComponentModel.DataAnnotations;

namespace IdentityCore.ViewModels
{
    public class LoginViewModel
    {
        //Email
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //Username
        [Required]
        public string UserName { get; set; }

        //Password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Remember Me
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        //Return Url
        public string ReturnUrl { get; set; }
    }
}
