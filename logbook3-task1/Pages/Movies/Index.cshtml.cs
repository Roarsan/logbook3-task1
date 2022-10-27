using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logbook3_task1;
using logbook3_task1.Data;

namespace logbook3_task1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly logbook3_task1.Data.logbook3_task1Context _context;

        public IndexModel(logbook3_task1.Data.logbook3_task1Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
