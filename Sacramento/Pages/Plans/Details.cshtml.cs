using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sacramento.Data;
using Sacramento.Models;

namespace Sacramento.Pages.Plans
{
    public class DetailsModel : PageModel
    {
        private readonly Sacramento.Data.SacramentoContext _context;

        public DetailsModel(Sacramento.Data.SacramentoContext context)
        {
            _context = context;
        }

        public Plan Plan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plan = await _context.Plan
                .Include(p => p.ClosingSong)
                .Include(p => p.ConductingLeader)
                .Include(p => p.IntermediateSong)
                .Include(p => p.OpeningSong)
                .Include(p => p.PresidingLeader)
                .Include(p => p.SacramentHymn).FirstOrDefaultAsync(m => m.ID == id);

            if (Plan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
