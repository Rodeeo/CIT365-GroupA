using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sacramento.Models;

namespace Sacramento.Pages.Leaders
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentoContext _context;

        public DetailsModel(SacramentoContext context)
        {
            _context = context;
        }

        public Leader Leader { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Leader = await _context.Leader.FirstOrDefaultAsync(m => m.ID == id);

            if (Leader == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
