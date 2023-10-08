using System.ComponentModel.DataAnnotations;

namespace IdentityCore.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
