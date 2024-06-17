using Smartphone_Shop.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Smartphone_Shop.Models.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly AppDbContext _appDb;

        public ShoppingCartRepository(AppDbContext appDb)
        {
            this._appDb = appDb;
        }

        public void AddPhoneToCart(int phoneId, string userMail)
        {
            var cartId = _appDb.ShoppingCarts.Where(x => x.UserEmail == userMail).Select(x => x.Id).ToArray();
            var phone = _appDb.Phone.SingleOrDefault(x => x.Id == phoneId);
            var brand = _appDb.Brand.SingleOrDefault(x => x.Id == phone.BrandId);

            var cartItem = new ShoppingCartItem
            {
                Phone = phone,
                ShoppingCartId = cartId[0],
                ItemImgUrl = phone.ImageUrl,
                ModelName = phone.ModelName,
                BrandName = brand.Name,
                Price = phone.Price
            };

            _appDb.ShoppingCartItems.Add(cartItem);
            _appDb.SaveChanges();
        }

        public void ClearCart(string userMail)
        {
            var cart = _appDb.ShoppingCarts.Where(x => x.UserEmail == userMail).Select(y => y.Id).ToArray();
            var cartId = cart[0];

            _appDb.ShoppingCartItems.RemoveRange(_appDb.ShoppingCartItems.Where(x => x.ShoppingCartId == cartId));
            _appDb.SaveChanges();
        }

        public void CreateCart(string userMail)
        {
            var cart = new ShoppingCart
            {
                UserEmail = userMail,
            };

            _appDb.ShoppingCarts.Add(cart);
            _appDb.SaveChanges();
        }

        public void DeleteFromCart(int itemId, string userMail)
        {
            var cart = _appDb.ShoppingCarts.Where(x => x.UserEmail == userMail).Select(y => y.Id).ToArray();
            var cartId = cart[0];
            
            var cartItem = _appDb.ShoppingCartItems.FirstOrDefault(x => x.Id == itemId);

            _appDb.ShoppingCartItems.Remove(cartItem);
            _appDb.SaveChanges();
        }

        public List<ShoppingCartItem> GetCartItems(string userMail)
        {
            var cart = _appDb.ShoppingCarts.Where(x => x.UserEmail == userMail).Select(y => y.Id).ToArray();
            var cartId = cart[0];
            var items = _appDb.ShoppingCartItems.Where(x => x.ShoppingCartId == cartId).ToList();

            return items;
        }
    }
}
