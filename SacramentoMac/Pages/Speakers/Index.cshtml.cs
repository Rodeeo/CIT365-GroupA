using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sacramento.Models;

namespace Sacramento.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly SacramentoContext _context;

        public IndexModel(SacramentoContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get;set; }

        public async Task OnGetAsync()
        {
            Speaker = await _context.Speaker.ToListAsync();
        }
    }
}
