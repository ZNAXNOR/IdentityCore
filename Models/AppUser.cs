using Microsoft.AspNetCore.Identity;

namespace IdentityCore.Models
{
    public class AppUser : IdentityUser
    {
        public string NickName { get; set; }
    }
}
