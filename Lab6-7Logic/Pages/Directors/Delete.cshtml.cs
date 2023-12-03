using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Data;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Directors
{
    public class DeleteModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public DeleteModel(Lab6_7Logic.Data.MovieLogicContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Director Director { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var director = await _context.Director.FirstOrDefaultAsync(m => m.Id == id);

            if (director == null)
            {
                return NotFound();
            }
            else
            {
                Director = director;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var director = await _context.Director.FindAsync(id);
            if (director != null)
            {
                Director = director;
                _context.Director.Remove(Director);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
