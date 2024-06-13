using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class ApplicationUser : IdentityUser
 
        {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public string Address { get; set; } = string.Empty;
    }
    }
