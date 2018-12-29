using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspCore.Models;
using AspCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace AspCore
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
            services.AddTransient<IFirstService, FirstService>();
            services.AddSingleton<ISecondService, SecondService>();
            services.AddSingleton<ViewTimeService>();
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PersonContext>(options => options.UseSqlServer(connection));
            services.AddMvc();
            services.AddDirectoryBrowser();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseFileServer(new FileServerOptions
                {
                    EnableDirectoryBrowsing = true,
                    EnableDefaultFiles = true,
                    FileProvider = new PhysicalFileProvider(
           Path.Combine(Directory.GetCurrentDirectory(), @"Files")),
                    RequestPath = new PathString("/page")
                });
                app.UseStaticFiles(new StaticFileOptions
                {
                    OnPrepareResponse = ctx =>
                    {
                        ctx.Context.Response.Headers.Append("X-SDA", DateTime.Now.ToString());
                    }
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }



            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Person}/{action=Index}/{id?}");
            });
        }
    }
}
