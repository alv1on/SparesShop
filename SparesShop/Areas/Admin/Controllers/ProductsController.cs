using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SparesShop.Data;
using SparesShop.Interfaces;
using SparesShop.Models;
using SparesShop.Models.ViewModels;
using SparesShop.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProductsController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly IProducts _products;
        private readonly DatabaseContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductsController(IWebHostEnvironment env, DataManager manager, IProducts products, DatabaseContext context)
        {
            this._env = env;
            this._dataManager = manager;
            _products = products;
            _context = context;
        }
        public ViewResult Index(int p = 1, int s = 10)
        {
            IEnumerable<Product> products = _products.GetProducts.Skip((p - 1) * s).Take(s);

            var items = new HomeViewModel
            {
                Products = products.ToList()
            };
            ViewBag.IsSearchResult = false;
            ViewBag.PageCount = _products.GetProducts.Count();
            ViewBag.CurrentPage = p;
            ViewBag.PageSize = s;
            return View(items);
        }

        public IActionResult Edit(int id)
        {
            var product = id == default ? new Product() : _dataManager.Products.GetProductById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_env.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);

                }

               _dataManager.Products.SaveProduct(model);
                return RedirectToAction(nameof(ProductsController.Index), nameof(ProductsController).CutController());
                
               
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            _dataManager.Products.DeleteProduct(Id);
            return RedirectToAction(nameof(ProductsController.Index), nameof(ProductsController).CutController());
        }

    }
}
