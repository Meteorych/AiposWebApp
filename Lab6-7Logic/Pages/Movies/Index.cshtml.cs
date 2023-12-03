﻿using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public IDictionary<int, Director> Director { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
            Director = await _context.Director.ToDictionaryAsync(director => director.Id);
        }
    }
}