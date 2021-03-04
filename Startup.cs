using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookSite.Models;
using Microsoft.EntityFrameworkCore;

namespace BookSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<BookShelfDBContext>(options =>
             {
                 options.UseSqlServer(Configuration["ConnectionStrings:BookConnection"]);

             });

            services.AddScoped<IBookRepository, EFBookRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //category pages
                endpoints.MapControllerRoute(
                    "catpage",
                    "{category}/P{page:int}",
                    new { Controller = "Home", action = "Index" });

                //page number pages
                endpoints.MapControllerRoute(
                    "page",
                    "Bookshelf/{page:int}",
                    new { Controller = "Home", action = "Index" });

                //only category
                endpoints.MapControllerRoute(
                    "category",
                    "{category}",
                    new { Controller = "Home", action = "Index" , page = 1});

                endpoints.MapControllerRoute(
                    "pagination",
                    "Bookshelf/P{page}",
                    new { Controller = "Home", action="Index" });

                endpoints.MapDefaultControllerRoute();
            });

            //add in seeddata and connect to app
            SeedData.EnsurePopulated(app);
        }
    }
}
