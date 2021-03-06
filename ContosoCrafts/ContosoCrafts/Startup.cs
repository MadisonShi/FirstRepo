using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ContosoCrafts.Services;
using System.Text.Json;
using ContosoCrafts.Models;
using Microsoft.AspNetCore.Http;

namespace ContosoCrafts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddTransient<JsonFileProductsService>(); //comes and goes; gets a new jsonfileproductsservice everytime it's called
            services.AddControllers();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //creates endpoints based on all razor pages
                endpoints.MapControllers();
                //manual web api
                /*endpoints.MapGet("/products", (context) =>
                {
                    var products = app.ApplicationServices.GetService<JsonFileProductsService>().GetProducts();
                    var json = JsonSerializer.Serialize<IEnumerable<Product>>;
                    return context.Response.WriteAsync(json);
                });*/
            });
        }
    }
}
