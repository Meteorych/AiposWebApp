﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6_7Logic.Models;

namespace Lab6_7Logic.Pages.Directors
{
    public class EditModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public EditModel(Lab6_7Logic.Data.MovieLogicContext context)
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

            var director =  await _context.Director.FirstOrDefaultAsync(m => m.Id == id);
            if (director == null)
            {
                return NotFound();
            }
            Director = director;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Director).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectorExists(Director.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DirectorExists(int id)
        {
            return _context.Director.Any(e => e.Id == id);
        }
    }
}
