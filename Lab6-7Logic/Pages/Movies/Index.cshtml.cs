using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Lab6_7Logic.Data.Lab6_7LogicContext _context;

        public IndexModel(Lab6_7Logic.Data.Lab6_7LogicContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
