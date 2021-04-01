using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SparesShop.Data;
using SparesShop.Interfaces;
using SparesShop.Models;
using SparesShop.Repositories;
using SparesShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparesShop.Infrastructure
{
    public static class App
    {
        public static IServiceCollection InitServices(IServiceCollection services, IConfigurationRoot configurationRoot)
        {
            services.AddTransient<IProducts, ProductsRepository>();
            services.AddTransient<IOrders, OrdersRepository>();  // передает экземпляр класса OrdersRepos интерфейсу(устанавливает зависимость)
            services.AddTransient<DataManager>();// объекты создаются каждый раз
            services.AddTransient<ISearch, SearchRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddTransient<IShopCart, ShopCartRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));// создается свой объект сервиса для каждого запроса
            services.AddDbContext<DatabaseContext>(x => x.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection")));//Добавляем контест БД
            services.AddIdentity<User, IdentityRole>(op =>
            {
                op.User.RequireUniqueEmail = true;
                op.Password.RequiredLength = 6;
                op.Password.RequireNonAlphanumeric = false;
                op.Password.RequireDigit = false;
                op.Password.RequireLowercase = false;
                op.Password.RequireUppercase = false;
                op.User.RequireUniqueEmail = true;


            }).AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(op =>
            {
                op.Cookie.Name = "Alvionise";
                op.Cookie.HttpOnly = true;
                op.LoginPath = "/account/login";
                op.AccessDeniedPath = "/account/login";
                op.SlidingExpiration = true;
            });
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });
            services.AddAuthorization(x =>
            {
                x.AddPolicy("UserArea", policy => { policy.RequireRole("user"); });
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // объект сервиса создается 1 раз и юзается постоянно
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                x.Conventions.Add(new AdminAreaAuthorization("User", "UserArea"));
            })
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
            services.AddMemoryCache();
            services.AddSession(); //  сессии(ряд запросов совершенных в одном браузере в течение времени)(хранится в хэш-таблице в кэше)
            //на клиенте инфа хранится в куках, время жизни информации по стандарту 20 минут
            services.AddResponseCompression(options => options.EnableForHttps = true);

            return services;
        }
    }
}
