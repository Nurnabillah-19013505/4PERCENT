using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotativa.AspNetCore;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FYPFinalCode.Models;



namespace FYPFinalCode
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        [Obsolete]
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            Configuration = configuration;
            RotativaConfiguration.Setup(env);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddDbContext<FYPdbcontext>(
            options =>
            options
            .UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));
            services
            .AddAuthentication("UserSecurity")
            .AddCookie("UserSecurity",
            options =>
            {
                options.LoginPath = "/Account/StudentLogin/";
                options.AccessDeniedPath = "/Account/Forbidden/";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(
            routes =>
            {
                routes.MapRoute(
    name: "default",
    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}