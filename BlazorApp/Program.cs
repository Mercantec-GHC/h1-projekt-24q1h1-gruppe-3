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

            // Generer dummy-data
            var createGames = new CreateGames();
            var allPCGames = createGames.GeneretePCDummyGames();
            var allPSGames = createGames.GeneretePSDummyGames();// Anta at denne metoden eksisterer og returnerer en liste av Item objekter
            var allXBOXGames = createGames.GenereteXBOXDummyGames();// Anta at denne metoden eksisterer og returnerer en liste av Item objekter

            // Opprett en instans av GameDataService
            var gameDataService = new GameDataService();

            // Sett inn dummy-data i databasen ved hjelp av GameDataService instansen
            //gameDataService.InsertDummyDataIntoDB(allPCGames, allPSGames, allXBOXGames);



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
