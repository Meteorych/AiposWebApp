using Lab6_7Logic.Data;
using Lab6_7Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_7Logic.Pages.Genres
{
    public class SeedDataGenres
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MovieLogicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieLogicContext>>());
            if (context?.Genre == null)
            {
                throw new ArgumentNullException(nameof(context), "Null movie logic context!");
            }

            // Look for any movies.
            if (context.Genre.Any())
            {
                return;   // DB has been seeded
            }

            context.Genre.AddRange(
                new Genre
                {
                    Name = "Comedy",
                    Description = "Fun!",
                },

                new Genre
                {
					Name = "Western",
					Description = "Blood!",
				},
                new Genre
                {
					Name = "Romantic Comedy",
					Description = "Fun and blood!",
				}

			);
            context.SaveChanges();
        }
    }
}
