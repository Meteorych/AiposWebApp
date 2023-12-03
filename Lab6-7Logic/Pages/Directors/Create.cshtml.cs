using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab6_7Logic.Data;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Directors
{
    public class CreateModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public CreateModel(Lab6_7Logic.Data.MovieLogicContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Director Director { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Director.Add(Director);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
