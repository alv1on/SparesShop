using SparesShop.Interfaces;

namespace SparesShop.Services
{
    public class DataManager
    {
        public IProducts Products { get; set; } 
        public IOrders Orders { get; set; }
        public ICategory Categories { get; set; }
        public DataManager(IProducts products, IOrders order, ICategory categories)  
        {
            Products = products;
            Orders = order;
            Categories = categories;
        }
    }
}
