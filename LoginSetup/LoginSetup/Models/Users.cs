using Microsoft.AspNetCore.Identity;

namespace LoginSetup.Models
{
    public class Users : IdentityUser

    {
        public string FullName { get; set; }
    }
}
