using DOAN.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DOAN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Thêm services cho session vào container
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Ví dụ cài đặt timeout là 30 phút
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>(); 
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Đặt app.UseSession() trước app.UseStaticFiles() và app.UseRouting()
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();



            app.MapAreaControllerRoute(
            name: "AdminArea",
            areaName: "Admin",
            pattern: "Admin/{controller=HomeAdmin}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {


                // Định nghĩa các route
                endpoints.MapControllerRoute(
                    name: "Product Detail",
                    pattern: "chi-tiet/{MetaTitle}/{id}",
                    defaults: new { controller = "Product", action = "Detail" }
                );

                // Cấu hình route mặc định (nếu có)
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.Run();
        }
    }
}
