using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Models
{
    public class OrderDone
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя ")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Недопустимая длина фамилии")]
        public string ClientSurname { get; set; }
        [Required(ErrorMessage = "Не указан адрес")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Недопустимая длина адреса")]
        public string ClientAddress { get; set; }
        [Required(ErrorMessage = "Не указан телефон")]
        [Phone(ErrorMessage = "Некорректный телефон")]
        [Display(Name = "ClientPhone")]
        public string ClientPhone { get; set; }
        [Required(ErrorMessage = "Не указана почта")]
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        [Display(Name = "ClientEmail")]
        public string ClientEmail { get; set; }
        public DateTime OrderTime { get; set; }
        public ICollection<OrderDetails> orderDetails { get; set; }
    }
}
