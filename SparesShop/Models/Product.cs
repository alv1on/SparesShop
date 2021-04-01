using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Не указано название товара")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Недопустимая длина названия")]
        public string Name { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указана цена товара")]
        [RegularExpression(@"[0-9]{2,10}", ErrorMessage = "Некорректная цена")]
        public string Price { get; set; }
        public bool IsFav { get; set; }
        [Required(ErrorMessage = "Не указан бренд товара")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Недопустимая длина бренда")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Не указан номер товара")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Недопустимая длина номера")]
        public string ArticleNumber { get; set; }

        public string TitleImagePath { get; set; }
        [Required(ErrorMessage = "Не указан идентификатор товара")]
        [RegularExpression(@"[0-9]{1,10}", ErrorMessage = "Некорректный идентификатор")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
