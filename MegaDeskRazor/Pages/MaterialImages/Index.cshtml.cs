using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazor.Pages.MaterialImages
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazorContext _context;

        public IndexModel(MegaDeskRazorContext context)
        {
            _context = context;
        }

        public IList<MaterialImage> MaterialImage { get;set; }

        public async Task OnGetAsync()
        {
            MaterialImage = await _context.MaterialImage.ToListAsync();
        }
    }
}
