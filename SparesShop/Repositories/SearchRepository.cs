using SparesShop.Interfaces;
using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Repositories
{
    public class SearchRepository : ISearch
    {
        private readonly IProducts _products;

        public SearchRepository()
        {
        }

        public SearchRepository(IProducts products)
        {
            _products = products;
        }

        public List<Product> Search(string search)
        {
            search = search.ToLower();
            var products = _products.GetProducts.ToList();
            var productsResult = new List<Product>();
            if (!string.IsNullOrEmpty(search))
            {
                productsResult = products.Where(s => s.Name.ToLower().StartsWith(search) || s.Brand.ToLower().StartsWith(search)||s.ArticleNumber.ToLower().StartsWith(search)).ToList();
                if (!productsResult.Any())
                {
                    productsResult = products.Where(s => s.Name.ToLower().Contains(search) || s.Brand.ToLower().StartsWith(search) || s.ArticleNumber.ToLower().StartsWith(search)).ToList();
                }
            }
            return productsResult;
        }
    }
}
