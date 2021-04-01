using SparesShop.Interfaces;
using SparesShop.Models;
using SparesShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Repositories
{
    public class ProductsRepository : IProducts
    {
        private readonly DatabaseContext _context;
        public ProductsRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Product GetProductById(int ProductId) => _context.Products.FirstOrDefault(p => p.Id == ProductId);
        public IEnumerable<Product> GetProducts => _context.Products.AsParallel().ToList(); 
        public IEnumerable<Product> GetFavProducts => _context.Products.Where(p => p.IsFav);
        public IEnumerable<Product> GetProductsById(List<int> ProductId) => _context.Products.Where(x => ProductId.Contains(x.Id)).ToList();

        public IEnumerable<Product> ProductList(string brand)
        {
            string _category = brand;
            IEnumerable<Product> products = null;
            if (string.IsNullOrEmpty(brand)) // если категория пустая - сортируем по productsId
            {
                products = GetProducts.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("KYB", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("KYB")).OrderBy(i => i.Id);
                }

                else if (string.Equals("REINZ", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("REINZ")).OrderBy(i => i.Id);
                }
                else if (string.Equals("EXEDY", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("EXEDY")).OrderBy(i => i.Id);
                }
                else if (string.Equals("CLEAN FILTERS", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("CLEAN FILTERS")).OrderBy(i => i.Id);
                }
                else if (string.Equals("KNECHT", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("KNECHT")).OrderBy(i => i.Id);
                }
                else if (string.Equals("KNECHT", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("TRW")).OrderBy(i => i.Id);
                }
                else if (string.Equals("NGK", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("NGK")).OrderBy(i => i.Id);
                }
                else if (string.Equals("ORIGINAL IMPERIUM", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("ORIGINAL IMPERIUM")).OrderBy(i => i.Id);
                }
                else if (string.Equals("RUVILLE", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("RUVILLE")).OrderBy(i => i.Id);
                }
                else if (string.Equals("JC AUTO", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("JC AUTO")).OrderBy(i => i.Id);
                }
                else if (string.Equals("EUROFLEX", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("EUROFLEX")).OrderBy(i => i.Id);
                }
                else if (string.Equals("POLMOSTROW", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("POLMOSTROW")).OrderBy(i => i.Id);
                }
                else if (string.Equals("PATRON", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("PATRON")).OrderBy(i => i.Id);
                }
                else if (string.Equals("TESH", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("TESH")).OrderBy(i => i.Id);
                }
                else if (string.Equals("VERNET-CALORSTAT", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("VERNET-CALORSTAT")).OrderBy(i => i.Id);
                }
                else if (string.Equals("VALEO", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("VALEO")).OrderBy(i => i.Id);
                }
                else if (string.Equals("SKF", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("SKF")).OrderBy(i => i.Id);
                }
                else if (string.Equals("DOLZ", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("DOLZ")).OrderBy(i => i.Id);
                }
                else if (string.Equals("MEAT&DORIA", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("MEAT&DORIA")).OrderBy(i => i.Id);
                }
                else if (string.Equals("POWERTEC", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("POWERTEC")).OrderBy(i => i.Id);
                }
                else if (string.Equals("GLYCO", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("GLYCO")).OrderBy(i => i.Id);
                }
                else if (string.Equals("NURAL", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("NURAL")).OrderBy(i => i.Id);
                }
                else if (string.Equals("AE", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("AE")).OrderBy(i => i.Id);
                }
                else if (string.Equals("GOETZE ENGINE", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("GOETZE ENGINE")).OrderBy(i => i.Id);
                }
                else if (string.Equals("KOLBENSCHMIDT", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("KOLBENSCHMIDT")).OrderBy(i => i.Id);
                }
                else if (string.Equals("INA", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("INA")).OrderBy(i => i.Id);
                }
                else if (string.Equals("AP", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("AP")).OrderBy(i => i.Id);
                }
                else if (string.Equals("WP", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("WP")).OrderBy(i => i.Id);
                }
                else if (string.Equals("BREMBO", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("BREMBO")).OrderBy(i => i.Id);
                }
                else if (string.Equals("EXEDY", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("EXEDY")).OrderBy(i => i.Id);
                }
                else if (string.Equals("ZM", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("ZM")).OrderBy(i => i.Id);
                }
                else if (string.Equals("CORTECO", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("CORTECO")).OrderBy(i => i.Id);
                }
                else if (string.Equals("SACHS", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("SACHS")).OrderBy(i => i.Id);
                }
                else if (string.Equals("NGK", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("NGK")).OrderBy(i => i.Id);
                }
                else if (string.Equals("HUTCHINSON", brand, StringComparison.OrdinalIgnoreCase)) // или сортируем по категориям
                {
                    products = GetProducts.Where(i => i.Brand.Equals("HUTCHINSON")).OrderBy(i => i.Id);
                }
            }
            return products;


        }

        public void SaveProduct(Product product)
        {
            var item = GetProductById(product.Id);

            if (item == null)
                _context.Products.Add(product);
            else
            {
                item.Name = product.Name;             
                item.Category = product.Category;
                item.Brand = product.Brand;
                item.ArticleNumber = product.ArticleNumber;
                item.CategoryId = product.CategoryId;
                item.Price = product.Price;
                item.IsFav = product.IsFav;
                item.TitleImagePath = product.TitleImagePath;

            }
            _context.SaveChanges();
        }
        public void DeleteProduct(int ProductId)    
        {
            var item = _context.Products.FirstOrDefault(x => x.Id == ProductId);
            _context.Products.Remove(item);
            _context.SaveChanges();
        }
    }
}
