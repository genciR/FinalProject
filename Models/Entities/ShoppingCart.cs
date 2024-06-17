using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smartphone_Shop.Models.Entities
{
    public class ShoppingCart
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserEmail { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
