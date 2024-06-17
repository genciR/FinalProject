using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Smartphone_Shop.Models.Entities
{
    public class CustomUser : IdentityUser
    {
        [PersonalData]
        [Required(ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        [StringLength(30, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [Required(ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        [StringLength(30, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
