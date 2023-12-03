using Microsoft.EntityFrameworkCore;

namespace Lab6_7Logic.Data
{
    public class MovieLogicContext : DbContext
    {
        public MovieLogicContext (DbContextOptions<MovieLogicContext> options)
            : base(options)
        {
        }

        public DbSet<Lab6_7Logic.Models.Movie> Movie { get; set; } = default!;
        public DbSet<Lab6_7Logic.Models.Director> Director { get; set; } = default!;
        public DbSet<Lab6_7Logic.Models.Actor> Actor { get; set; } = default!;
        public DbSet<Lab6_7Logic.Models.Genre> Genre { get; set; } = default!;
    }
}
