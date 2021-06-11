using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.Rushes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazorPagesRushContext _context;

        public CreateModel(MegaDeskRazorPagesRushContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rush Rush { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rush.Add(Rush);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
