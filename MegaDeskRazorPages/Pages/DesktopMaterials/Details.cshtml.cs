using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.DesktopMaterials
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskRazorPagesDesktopMaterialContext _context;

        public DetailsModel(MegaDeskRazorPagesDesktopMaterialContext context)
        {
            _context = context;
        }

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
    }
}
