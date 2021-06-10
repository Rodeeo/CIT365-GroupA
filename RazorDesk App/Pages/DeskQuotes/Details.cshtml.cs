using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorDesk_App.Data;
using RazorDesk_App.Models;

namespace RazorDesk_App.Pages.DeskQuotes
{
    public class DetailsModel : PageModel
    {
        private readonly RazorDesk_App.Data.RazorDesk_AppContext _context;

        public DetailsModel(RazorDesk_App.Data.RazorDesk_AppContext context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

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
    }
}
