using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskRazor.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public IndexModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get; set; }

        // Search feature vars
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            // Get all quotes
            var quotes = from m in _context.DeskQuote
                             select m;

            foreach (DeskQuote quote in quotes)
            {
                Console.WriteLine("Customer: " + quote.CustomerName);
            }

            // if search bar is not empty
            if (!string.IsNullOrEmpty(SearchString))
            {
                Console.WriteLine("Search string: " + SearchString);
                quotes = quotes.Where(s => s.CustomerName.Contains(SearchString));
            }

            DeskQuote = await quotes
                .Include(d => d.Desk)
                .Include(d => d.Desk.Material)
                .Include(d => d.Rush).ToListAsync();

        }
    }
}
