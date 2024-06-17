using System.ComponentModel.DataAnnotations;

namespace Smartphone_Shop.Models.Entities
{
    public class Color
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Name { get; set; }
    }
}
