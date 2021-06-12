using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazor.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public CreateModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        public SelectList Materials { get; set; }

        public IActionResult OnGet()
        {
            ViewData["DeskID"] = new SelectList(_context.Desk, "ID", "ID");
            ViewData["RushID"] = new SelectList(_context.Rush, "ID", "Description");
            ViewData["MaterialID"] = new SelectList(_context.DesktopMaterial, "ID", "Material");

            

            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.DateEntry = DateTime.Now;

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
