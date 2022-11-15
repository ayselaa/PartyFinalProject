using Business.Repositories;
using Business.Repository;
using Business.Services;
using DAL.Data;
using DAL.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace MyFinallyProje
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("Default"));
            });

            services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromMinutes(10);
            });

            services.AddHttpContextAccessor();


            services.AddScoped<IHomeBoxService, HomeBoxRepository>();
            services.AddScoped<IServiceService, ServiceRepository>();
            services.AddScoped<IServiceDetailService, ServiceDetailRepository>();
            services.AddScoped<IImageService, ImageRepository>();
            services.AddScoped<IBlogDetailsService, BlogDetailsRepository>();
            services.AddScoped<IBlogService, BlogRepository>();
            services.AddScoped<IProductService, ProductRepository>();
            services.AddScoped<IProductDetailService, ProductDetailRepository>();
            services.AddScoped<ITeamService, TeamRepository>();
            services.AddScoped<ITeamDetailService, TeamDetailRepository>();
            services.AddScoped<ICommentService, CommentRepository>();
            services.AddScoped<LayoutService>();
            services.AddScoped<IGalleryService, GalleryRepository>();
            services.AddScoped<ICategoryService, CategoryRepository>();
            services.AddScoped<IReservationService, ReservationRepository>();
            services.AddScoped<IOrderService, OrderRepository>();


            services.AddIdentity<AppUser, IdentityRole>()
           .AddEntityFrameworkStores<AppDbContext>()
           .AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options =>
            {
                options.Lockout.DefaultLockoutTimeSpan = System.TimeSpan.FromMinutes(1);
                options.Password.RequireDigit = true;
                options.User.RequireUniqueEmail = true;


            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Admin",
                 pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}");

                endpoints.MapControllerRoute(
                 name: "Default",
                      pattern: "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
