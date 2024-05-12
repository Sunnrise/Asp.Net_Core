using Dependency_Injection.Services;
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

namespace Dependency_Injection
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
            
            //services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog(4)));
            //services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

            
            //services.AddSingleton<ConsoleLog>();// ConsoleLog's consturctor has not a parameter so we can use this method
            services.AddSingleton<ConsoleLog>(p=> new ConsoleLog(5));// ConsoleLog's consturctor has a parameter so we can use this method
            services.AddSingleton<TextLog>();

            services.AddScoped<ConsoleLog>(p => new ConsoleLog(5));
            services.AddScoped<TextLog>();

            services.AddTransient<ConsoleLog>(p => new ConsoleLog(5));
            services.AddTransient<TextLog>();


            services.AddControllersWithViews();

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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
