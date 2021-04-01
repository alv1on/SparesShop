using Microsoft.AspNetCore.Mvc;
using SparesShop.Data;
using SparesShop.Interfaces;
using SparesShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {

        private readonly IProducts _products;
        private readonly ISearch _search;
        private readonly DatabaseContext _context;
        public IActionResult Index() => View();
        


    }
}
