using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sacramento.Data;
using Sacramento.Models;

namespace Sacramento.Pages.Hymns
{
    public class DetailsModel : PageModel
    {
        private readonly Sacramento.Data.SacramentoContext _context;

        public DetailsModel(Sacramento.Data.SacramentoContext context)
        {
            _context = context;
        }

        public Hymn Hymn { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hymn = await _context.Hymn.FirstOrDefaultAsync(m => m.ID == id);

            if (Hymn == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
