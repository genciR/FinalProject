using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Smartphone_Shop.Models;
using Smartphone_Shop.Models.Entities;
using Smartphone_Shop.Models.Repositories;
using Smartphone_Shop.Models.ViewModels;
using System.Linq;

namespace Smartphone_Shop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly AppDbContext _appDb;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, AppDbContext appDb)
        {
            this._shoppingCartRepository = shoppingCartRepository;
            this._appDb = appDb;
        }

        [Area("Identity")]
        public RedirectToRouteResult RedirectToLogin()
        {
            return RedirectToRoute("$/Identity/Account/Login");
            
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var mail = User.Identity.Name;

            if (User.Identity.IsAuthenticated)
            {
                var cart = _appDb.ShoppingCarts.FirstOrDefault(x => x.UserEmail == mail);

                if (cart == null)
                {
                    _shoppingCartRepository.CreateCart(mail);
                }

                var items = _shoppingCartRepository.GetCartItems(mail);
                if(items.Count < 0)
                {
                    return View();
                }
                else
                {
                    var shoppingCart = new ShoppingCart
                    {
                        ShoppingCartItems = items,
                    };

                    var shoppingCartViewModel = new ShoppingCartViewModel
                    {
                        ShoppingCart = shoppingCart,
                        TotalPrice = items.Sum(x => x.Price)
                    };

                    return View(shoppingCartViewModel);
                }               
            }
            else
            {
                return RedirectToAction("RedirectToLogin");
            }
        }

        [Authorize]
        public RedirectToActionResult AddToCart(int phoneId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var mail = User.Identity.Name;

                var cart = _appDb.ShoppingCarts.FirstOrDefault(x => x.UserEmail == mail);

                if(cart == null)
                {
                    _shoppingCartRepository.CreateCart(mail);
                }

                _shoppingCartRepository.AddPhoneToCart(phoneId, mail);

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("RedirectToLogin");
            }
        }

        public IActionResult RemoveFromCart(int itemId)
        {
            var mail = User.Identity.Name;
            _shoppingCartRepository.DeleteFromCart(itemId, mail);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Checkout()
        {
            if (User.Identity.IsAuthenticated)
            {
                CheckoutModel checkoutModel = new CheckoutModel();
                return View(checkoutModel);
            }
            else
            {
                return RedirectToAction("RedirectToLogin");
            }
        }

        [HttpPost]
        public IActionResult Checkout(CheckoutModel checkoutModel)
        {
            if (!ModelState.IsValid)
            {
                return View(checkoutModel);
            }
            else
            {
                var mail = User.Identity.Name;
                _shoppingCartRepository.ClearCart(mail);
                return RedirectToAction("PurchaseSuccess");
            }
        }

        [HttpGet]
        public IActionResult PurchaseSuccess()  
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("RedirectToLogin");
            }
        }
    }
}
