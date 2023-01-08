using Microsoft.EntityFrameworkCore;
using PurpleBuzzAspNet.DAL;

namespace PurpleBuzzAspNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
            });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment()) { }

            app.UseStaticFiles();

            app.UseRouting();


            app.UseEndpoints(endpoint => { endpoint.MapDefaultControllerRoute(); });

            app.Run();
        }
    }
}