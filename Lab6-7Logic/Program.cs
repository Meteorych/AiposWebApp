using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Data;
using Lab6_7Logic.Pages.Directors;
using Lab6_7Logic.Pages.Movies;

namespace Lab6_7Logic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MovieLogicContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("MovieLogicContext") ?? throw new InvalidOperationException("Connection string 'MovieLogicContext' not found.")));
            
            
            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                SeedDataMovies.Initialize(services);
            }

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedDataDirectors.Initialize(services);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
