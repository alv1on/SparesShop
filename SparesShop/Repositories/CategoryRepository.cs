using SparesShop.Data;
using SparesShop.Interfaces;
using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Repositories
{
    public class CategoryRepository:ICategory
    {
        private readonly DatabaseContext _context;
        public CategoryRepository(DatabaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategories => _context.Categories.AsParallel().ToList();
        public Category GetCategoryById(int Id) => _context.Categories.FirstOrDefault(p => p.Id == Id);
        public IEnumerable<Category> GetCategoriesById(List<int> Id) => _context.Categories.Where(x => Id.Contains(x.Id)).ToList();
        public void SaveCategory(Category category)
        {
            var item = GetCategoryById(category.Id);

            if (item == null)
                _context.Categories.Add(category);
            else
            {
                item.Name = category.Name;

            }
            _context.SaveChanges();
        }
        public void DeleteCategory(int Id)
        {
            var item = _context.Categories.FirstOrDefault(x => x.Id == Id);
            _context.Categories.Remove(item);
            _context.SaveChanges();
        }
    }
}

