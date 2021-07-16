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
    public class IndexModel : PageModel
    {
        private readonly Sacramento.Data.SacramentoContext _context;

        public IndexModel(Sacramento.Data.SacramentoContext context)
        {
            _context = context;
        }

        public IList<Plan> Plan { get;set; }

        public async Task OnGetAsync()
        {
            Plan = await _context.Plan
                .Include(p => p.ClosingSong)
                .Include(p => p.ConductingLeader)
                .Include(p => p.IntermediateSong)
                .Include(p => p.OpeningSong)
                .Include(p => p.PresidingLeader)
                .Include(p => p.SacramentHymn).ToListAsync();
        }
    }
}
