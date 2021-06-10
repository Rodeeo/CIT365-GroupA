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
    public class IndexModel : PageModel
    {
        private readonly RazorDesk_App.Data.RazorDesk_AppContext _context;

        public IndexModel(RazorDesk_App.Data.RazorDesk_AppContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
