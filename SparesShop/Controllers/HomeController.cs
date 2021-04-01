using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SparesShop.Data;
using SparesShop.Interfaces;
using SparesShop.Models;
using SparesShop.Models.ViewModels;

namespace SparesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _products;
        private readonly ISearch _search;
        private readonly DatabaseContext _context;
        private readonly ICategory _category;

        public HomeController(IProducts products, ISearch search, DatabaseContext context, ICategory category)
        {
            _products = products;
            _search = search;
            _context = context;
            _category = category;
        }


        public ViewResult Index(int p = 1, int s = 10)
        {
            IEnumerable<Product> products = _products.GetFavProducts.Skip((p - 1) * s).Take(s);

            var items = new HomeViewModel
            {
                Products = products.ToList()
            };
            ViewBag.IsSearchResult = false;
            ViewBag.PageCount = _products.GetFavProducts.Count();
            ViewBag.CurrentPage = p;
            ViewBag.PageSize = s;
            return View(items);
        }

        [HttpPost] 
        public ViewResult Search(string search, int p = 1, int s = 10)
        {
            ViewBag.IsSearchResult = true;

            var productsResult = _search.Search(search);

            var items = new HomeViewModel
            {
                Products = productsResult.Skip((p - 1) * s).Take(s)
            };
            ViewBag.PageCount = _search.Search(search).Count();
            ViewBag.CurrentPage = p;
            ViewBag.PageSize = s;
            return View("Index", items);

        }
        public IActionResult Contacts() => View();
        public IActionResult Links() => View();



    }
}
