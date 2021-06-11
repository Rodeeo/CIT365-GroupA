using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.Rushes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazorPagesRushContext _context;

        public IndexModel(MegaDeskRazorPagesRushContext context)
        {
            _context = context;
        }

        public IList<Rush> Rush { get;set; }

        public async Task OnGetAsync()
        {
            Rush = await _context.Rush.ToListAsync();
        }
    }
}
