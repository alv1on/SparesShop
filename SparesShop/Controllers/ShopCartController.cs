using Microsoft.AspNetCore.Mvc;
using SparesShop.Interfaces;
using SparesShop.Models;
using SparesShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IProducts _product;
        private readonly ShopCart _ShopCart;
        public readonly IShopCart _shopCart;
        public ShopCartController(IProducts product, ShopCart ShopCart, IShopCart shopCart)
        {
            _product = product;
            _shopCart = shopCart;
            _ShopCart = ShopCart;
        }
        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _ShopCart.ShopCartItems = items;

            var item = new ShopCartViewModel
            {
                ShopCart = _ShopCart
            };
            return View(item);
        }
        public RedirectToActionResult AddToCart(int id)
        {
            var item = _product.GetProducts.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
