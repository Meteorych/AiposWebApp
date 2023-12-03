using Lab6_7Logic.Data;
using Lab6_7Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_7Logic.Pages.Actors
{
    public class SeedDataActors
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MovieLogicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieLogicContext>>());
            if (context?.Actor == null)
            {
                throw new ArgumentNullException(nameof(context), "Null movie logic context!");
            }

            // Look for any movies.
            if (context.Actor.Any())
            {
                return;   // DB has been seeded
            }

            context.Actor.AddRange(
                new Actor
                {
                    FirstName = "Bill",
                    LastName = "Murray",
					BirthDate = DateOnly.Parse("1937-2-12"),
                    Description = "Actor of the world!",
                },

                new Actor
                {
                    FirstName = "Shishi",
                    LastName = "Mishi",
                    BirthDate = DateOnly.Parse("1945-3-13"),
                    Description = "Yeeaaah",
                }
            );
            context.SaveChanges();
        }
    }
}
