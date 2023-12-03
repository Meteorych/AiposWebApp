using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public IndexModel(Lab6_7Logic.Data.MovieLogicContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;
        public IDictionary<int, Director> Directors { get; set; }
        public IDictionary<int, Genre> Genres { get; set; }
        public IDictionary<int, Actor> MainActor { get; set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
            Directors = await _context.Director.ToDictionaryAsync(director => director.Id);
            Genres = await _context.Genre.ToDictionaryAsync(genre => genre.Id);
            MainActor = await _context.Actor.ToDictionaryAsync(actor => actor.Id);
        }
    }
}
