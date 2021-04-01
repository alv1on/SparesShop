using Microsoft.AspNetCore.Mvc;
using SparesShop.Interfaces;
using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrders _order;
        private readonly IProducts _product;


        public OrdersController(IProducts _products, IOrders _orders)
        {
            this._order = _orders;
            this._product = _products;
        }

        public IActionResult Checkout(IEnumerable<int> orderList)
        {
            ViewBag.OrderList = orderList;
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(OrderDone order)
        {
            if (ModelState.IsValid)
            {
                _order.CreateOrder(order);
                return RedirectToAction("Complete", order);
            }
            return View(order);
        }

        public IActionResult Complete(IEnumerable<int> orderList, string name, string surname, string address, string phone, string email)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<Product> products = null;
                products = _product.GetProductsById(orderList.ToList());

                var orders = new List<OrderDone>
            { new OrderDone
                {

                    ClientAddress = address,
                    ClientEmail = email,
                    ClientName = name,
                    ClientPhone = phone,
                    ClientSurname = surname
                }
            };


                foreach (var order in orders)
                {
                    order.orderDetails = new List<OrderDetails>();
                    foreach (var productsItem in products)
                    {
                        order.orderDetails.Add(new OrderDetails
                        {
                            OrderDoneId = order.Id,
                            ProductPrice = productsItem.Price,
                            ProductName = productsItem.Name
                        });
                    }
                }

                _order.CreateOrderList(orders);

                ViewBag.Message = "Done";
            }
            return View();


        }
    }
}
