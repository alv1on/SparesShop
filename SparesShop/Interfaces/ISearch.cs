using SparesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Interfaces
{
    public interface ISearch
    {
        List<Product> Search(string search);
    }
}
