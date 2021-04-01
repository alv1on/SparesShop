using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано название категории")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Недопустимая длина названия")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
