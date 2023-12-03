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
    public class IndexModel : PageModel
    {
        private readonly Lab6_7Logic.Data.MovieLogicContext _context;

        public IndexModel(Lab6_7Logic.Data.MovieLogicContext context)
        {
            _context = context;
        }

        public IList<Director> Director { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Director = await _context.Director.ToListAsync();
        }
    }
}
