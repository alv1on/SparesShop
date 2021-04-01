using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Interfaces
{
    public interface IShopCart
    {
        void AddToCart(Product products);
        List<ShopCartItem> GetShopItems();
    }
}
