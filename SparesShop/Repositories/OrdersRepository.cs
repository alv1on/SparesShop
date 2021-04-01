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
    public class OrdersRepository : IOrders
    {
        private readonly DatabaseContext _context; 
        public ShopCart ShopCart { get; } 
        public OrdersRepository(DatabaseContext context, ShopCart shopCart) 
        {
            _context = context;
            ShopCart = shopCart;
        }
        public IEnumerable<OrderDone> GetOrders => _context.OrderDone.AsParallel().ToList(); 
        public IEnumerable<OrderDetails> GetDetails => _context.OrderDetail.AsParallel().ToList();
        public void CreateOrderList(IEnumerable<OrderDone> orderList)   
        {
            foreach (var order in orderList)
            {
                CreateOrder(order);
            }
        }
        public void CreateOrder(OrderDone order) 
        {
            order.OrderTime = DateTime.Now;
            _context.OrderDone.Add(order);
            _context.ShopCartItem.RemoveRange(_context.ShopCartItem.ToList());
            _context.SaveChanges();
        }
        public void DeleteOrder(int OrderDoneId)    
        {
            var item = _context.OrderDone.FirstOrDefault(x => x.Id == OrderDoneId);
            _context.OrderDone.Remove(item);
            _context.SaveChanges();
        }
        public void DeleteDetail(int OrderDetailId) 
        {
            var item = _context.OrderDetail.FirstOrDefault(x => x.Id == OrderDetailId);
            _context.OrderDetail.Remove(item);
            _context.SaveChanges();
        }
    }
}
