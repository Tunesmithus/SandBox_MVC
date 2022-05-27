using Microsoft.AspNetCore.Identity;

namespace SandBox_MVC.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? CompanyName { get; set; }


    }
}
