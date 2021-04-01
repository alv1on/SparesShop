using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Interfaces
{
    public interface IProducts 
    {
        IEnumerable<Product> ProductList(string brand);
        IEnumerable<Product> GetProducts { get; }
        IEnumerable<Product> GetFavProducts { get; }
        void SaveProduct(Product product);
        void DeleteProduct(int ProductId);
        Product GetProductById(int productId);
        IEnumerable<Product> GetProductsById(List<int> ProductId);

    }
}
