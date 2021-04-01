using SparesShop.Interfaces;
using SparesShop.Models;
using Microsoft.EntityFrameworkCore;
using SparesShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Repositories
{
    public class ShopCartRepository : IShopCart
    {
        private readonly DatabaseContext _context;
        private readonly ShopCart _shopCart;
        public ShopCartRepository(DatabaseContext context, ShopCart shopCart)
        {
            _context = context;
            _shopCart = shopCart;
        }
        public void AddToCart(Product products)
        {
            _context.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = _shopCart.Id,
                Product = products,
                ProductPrice = products.Price
            });
            _context.SaveChanges();

        }
         public List<ShopCartItem> GetShopItems()
        {
            return _context.ShopCartItem.Where(c => c.ShopCartId == _shopCart.Id).Include(s => s.Product).ToList();
        }
    }
}
