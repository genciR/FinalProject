using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smartphone_Shop.Models.Entities
{
    public class CheckoutModel
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        [StringLength(30, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(30, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your zip code")]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        [StringLength(50)]
        public string Country { get; set; }
    }
}
