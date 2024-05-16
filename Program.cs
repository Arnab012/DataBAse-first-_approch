using DataBAse_first__approch.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBAse_first__approch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var provider=builder.Services.BuildServiceProvider();
            var config = provider.GetService<IConfiguration>();
            builder.Services.AddDbContext<CodeFirstApprochContext>(item => item.UseSqlServer(config.GetConnectionString("arnab")));
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

//This is scaffolding the modal and the db context file form an exiting dataabse 

//Scaffold - DbContext "server=LAPTOP-OR5I0HOC;database=CodeFirstApproch;trusted_connection=true; Encrypt=false;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
//This is for Upadting the new tabel of any other chages in the  DataBase
//Scaffold - DbContext "server=LAPTOP-OR5I0HOC;database=CodeFirstApproch;trusted_connection=true; Encrypt=false;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models -force