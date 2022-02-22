using BiciShop.Models;
using BLL.Services;
using DAL.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiciShop
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
            string connectionStr = Configuration.GetConnectionString("DefaultConnection");
            string identityStr = Configuration.GetConnectionString("IdentityConnection");

            services.AddDbContext<BiciContext>(options => options.UseSqlServer(connectionStr));
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(identityStr));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
                {
                    option.RequireHttpsMetadata = false;
                    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = Configuration["Jwt:Audience"],
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
                        
                    };
                });
            
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>();

            services.AddScoped<IRepository<Bicicleta>, BiciRepo>();
            services.AddScoped<IRepository<Order>, OrderRepo>();
            services.AddScoped<IRepository<BiciType>, BiciTypeRepo>();
          
            services.AddScoped<BiciService>(provider =>
            {
                var dependency = provider.GetRequiredService<IRepository<Bicicleta>>();
                return new BiciService(dependency);
            });
            services.AddScoped<OrderService>(provider =>
            {
                var dependency = provider.GetRequiredService<IRepository<Order>>();
                return new OrderService(dependency);
            });
            services.AddScoped<BiciTypeService>(provider =>
            {
                var dependency = provider.GetRequiredService<IRepository<BiciType>>();
                return new BiciTypeService(dependency);
            });
            services.AddControllersWithViews();

            services.AddSession();
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
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();

           
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
            });
        }
    }
}
