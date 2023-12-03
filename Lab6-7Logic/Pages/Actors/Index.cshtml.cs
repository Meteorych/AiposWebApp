using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Actors
{
    public class IndexModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public IndexModel(Lab6_7Logic.Data.MovieLogicContext context)
        {
            _context = context;
        }

        public IList<Actor> Actor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Actor = await _context.Actor.ToListAsync();
        }
    }
}
