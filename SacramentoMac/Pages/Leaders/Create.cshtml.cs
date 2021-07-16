using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sacramento.Models;

namespace Sacramento.Pages.Leaders
{
    public class CreateModel : PageModel
    {
        private readonly SacramentoContext _context;

        public CreateModel(SacramentoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Leader Leader { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Leader.Add(Leader);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
