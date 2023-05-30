using GameRecomWebProject.Controllers.Helpers;
using GameRecomWebProject.Controllers.Helpers.Deserialize.Default_Deserializer.RAWG_Deserializer;
using GameRecomWebProject.Models.BusinessLogic.Abstract;
using GameRecomWebProject.Models.BusinessLogic.Concrete;
using GameRecomWebProject.Models.Utilities.Deserialize;
using GameRecomWebProject.Models.Utilities.Deserialize.Default_Deserializer.RAWG_Deserializer;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace GameRecomWebProject
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IAppService, AppManager>();
            builder.Services.AddSingleton<IDeserializer,Deserializer>();

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
                pattern: "{controller=home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}