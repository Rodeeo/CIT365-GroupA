using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazor.Pages.DesktopMaterials
{
    public class DeleteModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public DeleteModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DesktopMaterial DesktopMaterial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DesktopMaterial = await _context.DesktopMaterial.FirstOrDefaultAsync(m => m.ID == id);

            if (DesktopMaterial == null)
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

            DesktopMaterial = await _context.DesktopMaterial.FindAsync(id);

            if (DesktopMaterial != null)
            {
                _context.DesktopMaterial.Remove(DesktopMaterial);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
