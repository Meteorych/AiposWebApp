using Lab6_7Logic.Data;
using Lab6_7Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_7Logic.Pages.Directors
{
    public class SeedDataDirectors
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MovieLogicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieLogicContext>>());
            if (context?.Director == null)
            {
                throw new ArgumentNullException(nameof(context), "Null movie logic context!");
            }

            // Look for any movies.
            if (context.Director.Any())
            {
                return;   // DB has been seeded
            }

            context.Director.AddRange(
                new Director
                {
                    Name = "John Doe",
                    BirthDate = DateOnly.Parse("1937-2-12"),
                    Description = "Director of the world!",
                },

                new Director
                {
                    Name = "Joanna Doe",
                    BirthDate = DateOnly.Parse("1945-3-13"),
                    Description = "Catch all ghosts in New York!",
                }
            );
            context.SaveChanges();
        }
    }
}
