using System.ComponentModel.DataAnnotations;

namespace IdentityCore.ViewModels
{
    public class ExternalLoginViewModel
    {
        // Email
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //Name        
        public string Name { get; set; }
    }
}
