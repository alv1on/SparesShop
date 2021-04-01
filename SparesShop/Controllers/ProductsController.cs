using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SparesShop.Data;
using SparesShop.Interfaces;
using SparesShop.Models;
using SparesShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProducts _list;
        private readonly DatabaseContext _context;
        private readonly ICategory _category;


        public ProductsController(IProducts list, ICategory category, DatabaseContext context)
        {
            _list = list;
            _category = category;
            _context = context;

        }
        [Route("Product/ProductList")]
        [Route("Product/ProductList/{brand}")]
        public ActionResult ProductList(string brand, int p = 1, int s = 10)
        {
            var products = _list.ProductList(brand).Skip((p - 1) * s).Take(s);
            var CurrCategory = brand;
            var item = new ProductListViewModel
            {
                Products = products,
                CurrCategory = CurrCategory
            };

            ViewBag.PageCount = _list.ProductList(brand).Count();
            ViewBag.CurrentPage = p;
            ViewBag.PageSize = s;
            return View(item);
        }
    }

}

