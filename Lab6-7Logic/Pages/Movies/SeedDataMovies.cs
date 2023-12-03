using Lab6_7Logic.Data;
using Lab6_7Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_7Logic.Pages.Movies;

public static class SeedDataMovies
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MovieLogicContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MovieLogicContext>>());
        if (context == null || context.Movie == null)
        {
            throw new ArgumentNullException(nameof(context), "Null movie logic context!");
        }

        // Look for any movies.
        if (context.Movie.Any())
        {
            return;   // DB has been seeded
        }

        context.Movie.AddRange(
            new Movie
            {
                MovieName = "When Harry Met Sally",
                ReleaseDate = DateOnly.Parse("1989-2-12"),
                GenreId = new []{3},
                Description = "Awesome dramedy!",
                DirectorId = 1
            },

            new Movie
            {
                MovieName = "Ghostbusters",
                ReleaseDate = DateOnly.Parse("1984-3-13"),
                GenreId = new[] { 1 },
                Description = "Catch all ghosts in New York!",
                DirectorId = 1
            },

            new Movie
            {
                MovieName = "Ghostbusters 2",
                ReleaseDate = DateOnly.Parse("1986-2-23"),
                GenreId = new[]{1},
                Description = "Sequel to cult film!",
                DirectorId = 1
            },

            new Movie
            {
                MovieName = "Rio Bravo",
                ReleaseDate = DateOnly.Parse("1959-4-15"),
                GenreId = new []{2},
                DirectorId = 1
            }
        );
        context.SaveChanges();
    }
}