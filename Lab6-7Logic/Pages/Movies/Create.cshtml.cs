using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Lab6_7Logic.Data.Lab6_7LogicContext _context;

        public CreateModel(Lab6_7Logic.Data.Lab6_7LogicContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
