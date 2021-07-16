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
    public class DeleteModel : PageModel
    {
        private readonly SacramentoContext _context;

        public DeleteModel(SacramentoContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Leader = await _context.Leader.FindAsync(id);

            if (Leader != null)
            {
                _context.Leader.Remove(Leader);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
