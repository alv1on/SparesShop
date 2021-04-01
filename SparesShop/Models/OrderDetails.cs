using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderDoneId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
    }
}
