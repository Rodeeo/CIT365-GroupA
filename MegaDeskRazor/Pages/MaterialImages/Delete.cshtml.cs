using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazor.Pages.MaterialImages
{
    public class DeleteModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public DeleteModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MaterialImage MaterialImage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MaterialImage = await _context.MaterialImage.FirstOrDefaultAsync(m => m.ID == id);

            if (MaterialImage == null)
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

            MaterialImage = await _context.MaterialImage.FindAsync(id);

            if (MaterialImage != null)
            {
                _context.MaterialImage.Remove(MaterialImage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
