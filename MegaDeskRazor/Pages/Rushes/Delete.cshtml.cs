using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazor.Pages.Rushes
{
    public class DeleteModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public DeleteModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rush = await _context.Rush.FindAsync(id);

            if (Rush != null)
            {
                _context.Rush.Remove(Rush);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
