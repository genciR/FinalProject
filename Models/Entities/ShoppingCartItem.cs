
using Smartphone_Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone_Shop.Models
{   
    public class ShoppingCartItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Phone Phone { get; set; }
        [Required]
        public string ItemImgUrl { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string BrandName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string ModelName { get; set; }
        public string Color { get; set; }
        [Required]
        public int Ram { get; set; }    
        [Required]
        public int Storage { get; set; }    
        [Required]
        public double Price { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
    }       
}