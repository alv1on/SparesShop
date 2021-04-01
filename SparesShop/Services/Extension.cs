using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SparesShop.Services
{
    public static class Extension   //расширение
    {
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
       
    }
}
