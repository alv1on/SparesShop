using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SparesShop.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SparesShop
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IWebHostEnvironment configuration)
        {
            _confString = new ConfigurationBuilder().SetBasePath(configuration.ContentRootPath).AddJsonFile("dbsettings.json").Build();//���������� ������������
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) // ������������ �������
        {
            App.InitServices(services, _confString);
        }

        //IWebHostEnv ��� �������������� � ������, � ������� �������� ����������, IApplicationBuilder - Run,Map,Use ��� middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // ��������� ���������
        {
            // middleware
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers.Add("Cache-Control", "public,max-age=600");
                }
            });
            app.UseSession();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStatusCodePages();
            app.UseResponseCompression();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("user", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
