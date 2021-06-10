using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorDesk_App.Data;
using RazorDesk_App.Models;

namespace RazorDesk_App.Pages.DeskQuotes
{
    public class EditModel : PageModel
    {
        private readonly RazorDesk_App.Data.RazorDesk_AppContext _context;

        public EditModel(RazorDesk_App.Data.RazorDesk_AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.ID == id);
        }
    }
}
