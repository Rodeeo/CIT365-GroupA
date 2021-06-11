using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.Rushes
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskRazorPagesRushContext _context;

        public DetailsModel(MegaDeskRazorPagesRushContext context)
        {
            _context = context;
        }

        public Rush Rush { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rush = await _context.Rush.FirstOrDefaultAsync(m => m.ID == id);

            if (Rush == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
