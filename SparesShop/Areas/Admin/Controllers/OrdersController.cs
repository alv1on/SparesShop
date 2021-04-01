using Microsoft.AspNetCore.Mvc;
using SparesShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly DataManager _dataManager;
        public OrdersController(DataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        public IActionResult Index() => View(_dataManager.Orders.GetOrders);

        public IActionResult Details() => View(_dataManager.Orders.GetDetails);

        [HttpPost]
        public IActionResult Delete(int OrderDoneId)
        {
            _dataManager.Orders.DeleteOrder(OrderDoneId);
            return RedirectToAction(nameof(OrdersController.Index), nameof(OrdersController).CutController());
        }
        public IActionResult DeleteDetails(int OrderDetailId)
        {
            _dataManager.Orders.DeleteDetail(OrderDetailId);
            return RedirectToAction(nameof(OrdersController.Details), nameof(OrdersController).CutController()); // CutController - расширение
        }
    }
}
