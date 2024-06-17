using System.Collections.Generic;

namespace Smartphone_Shop.Models.Repositories
{
    public interface IShoppingCartRepository
    {
        public void CreateCart(string userMail);
        public void AddPhoneToCart(int phoneId, string userMail);
        public List<ShoppingCartItem> GetCartItems(string userMail);
        public void DeleteFromCart(int itemId, string userMail);
        public void ClearCart(string userMail); 

    }
}   
