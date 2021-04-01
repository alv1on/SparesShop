using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories { get; }
        void SaveCategory(Category category);
        void DeleteCategory(int Id);
        Category GetCategoryById(int Id);
        IEnumerable<Category> GetCategoriesById(List<int> Id);
    }
}
