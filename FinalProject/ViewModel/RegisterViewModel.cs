using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }  // Add this property

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }  // Add this property

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }  // Add this property

        [Required]
        [StringLength(200)]
        public string Address { get; set; }  // Add this property
    }
}
