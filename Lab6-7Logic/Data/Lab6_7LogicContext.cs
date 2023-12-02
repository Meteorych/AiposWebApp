using Microsoft.EntityFrameworkCore;

namespace Lab6_7Logic.Data
{
    public class Lab6_7LogicContext : DbContext
    {
        public Lab6_7LogicContext (DbContextOptions<Lab6_7LogicContext> options)
            : base(options)
        {
        }

        public DbSet<Lab6_7Logic.Models.Movie> Movie { get; set; } = default!;
    }
}
