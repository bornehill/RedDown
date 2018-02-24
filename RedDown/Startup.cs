using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using RedDown.Data;
using RedDown.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RedDown
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _env;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<AuthUser, Role>(cfg => {
                cfg.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<RedDownContext>();

            services.AddDbContext<RedDownContext>(cfg => { cfg.UseSqlServer(_configuration.GetConnectionString("RedDownConnection")); });

            services.AddScoped<IRedDownRepository, RedDownRepository>();
            services.AddAutoMapper();
            services.AddMvc()
                .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var _context = new RedDownContext(new DbContextOptionsBuilder<RedDownContext>().UseSqlServer(_configuration.GetConnectionString("RedDownConnection")).Options))
            {
                _context.Database.Migrate();
            };

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();
            app.UseMvc(cfg => {
                cfg.MapRoute("Default", "{controller}/{action}/{id?}", new { controller = "App", Action = "Registry" });
            });
        }
    }
}
