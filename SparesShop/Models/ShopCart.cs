using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SparesShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Models
{
    public class ShopCart
    {
        public string Id { get; set; }
        public List<ShopCartItem> ShopCartItems { get; set; }
        public ShopCart(DatabaseContext context)
        { }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<DatabaseContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { Id = shopCartId };
        }
    }
}
