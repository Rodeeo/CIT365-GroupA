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
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public DetailsModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

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
    }
}
