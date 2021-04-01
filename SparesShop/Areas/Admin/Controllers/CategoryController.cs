using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SparesShop.Data;
using SparesShop.Models;
using SparesShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController:Controller
    {
        private readonly DataManager _dataManager;
        private readonly DatabaseContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(IWebHostEnvironment env, DataManager manager)
        {
            this._env = env;
            this._dataManager = manager;
        }
        public IActionResult Index() => View(_dataManager.Categories.GetCategories);
        public IActionResult Edit(int id)
        {
            var category = id == default ? new Category() : _dataManager.Categories.GetCategoryById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                _dataManager.Categories.SaveCategory(model);
                return RedirectToAction(nameof(CategoryController.Index), nameof(CategoryController).CutController());
            }
            else
            {
                ModelState.AddModelError("category", "Ошибка");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            _dataManager.Categories.DeleteCategory(Id);
            return RedirectToAction(nameof(CategoryController.Index), nameof(CategoryController).CutController());
        }
    }
}
