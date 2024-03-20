using BlazorApp.Components;
using DomainModels;
using Microsoft.Extensions.Configuration;
using static DomainModels.GameDataService;

namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfiguration Configuration = builder.Configuration;
            var connectionString = Configuration.GetConnectionString("Defaultconnection") ?? Environment.GetEnvironmentVariable("DefaultConnection");
            var createGames = new CreateGames();
            builder.Services.AddSingleton<List<Item>>(sp => createGames.GenereteDummyItems());
            builder.Services.AddSingleton<List<User>>(sp => createGames.GenerateDummyUsers());
                


            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
