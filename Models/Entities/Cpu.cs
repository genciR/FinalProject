using System.ComponentModel.DataAnnotations;

namespace Smartphone_Shop.Models
{
    public class Cpu
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string ModelName { get; set; }
        [Required]
        public double Frequency { get; set; }
        //in GHz (gigahertz)
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string GraphicsChip { get; set; }
        [Required]
        public int NumOfCores { get; set; }
        [Required]
        public int ManProcess { get; set; }
        //in nm (nanometer)
    }
}
