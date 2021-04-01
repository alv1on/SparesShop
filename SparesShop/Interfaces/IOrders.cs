using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Interfaces
{
    public interface IOrders
    {
        IEnumerable<OrderDone> GetOrders { get; }
        IEnumerable<OrderDetails> GetDetails { get; }
        void CreateOrder(OrderDone order);
        void CreateOrderList(IEnumerable<OrderDone> orderList);
        void DeleteOrder(int OrderDoneId);
        void DeleteDetail(int OrderDetailId);
    }
}
