using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazor.Pages.MaterialImages
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public CreateModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MaterialImage MaterialImage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MaterialImage.Add(MaterialImage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
