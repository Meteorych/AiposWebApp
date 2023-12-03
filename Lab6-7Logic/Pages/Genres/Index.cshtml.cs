using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Genres
{
    public class IndexModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public IndexModel(Lab6_7Logic.Data.MovieLogicContext context)
        {
            _context = context;
        }

        public IList<Genre> Genre { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Genre = await _context.Genre.ToListAsync();
        }
    }
}
