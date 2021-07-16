using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sacramento.Models;

namespace Sacramento.Pages.Plans
{
    public class EditModel : PageModel
    {
        private readonly SacramentoContext _context;

        public EditModel(SacramentoContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["ClosingSongID"] = new SelectList(_context.Hymn, "ID", "ID");
           ViewData["ConductingLeaderID"] = new SelectList(_context.Leader, "ID", "Discriminator");
           ViewData["IntermediateSongID"] = new SelectList(_context.Hymn, "ID", "ID");
           ViewData["OpeningSongID"] = new SelectList(_context.Hymn, "ID", "ID");
           ViewData["PresidingLeaderID"] = new SelectList(_context.Leader, "ID", "Discriminator");
           ViewData["SacramentHymnID"] = new SelectList(_context.Hymn, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Plan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(Plan.ID))
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

        private bool PlanExists(int id)
        {
            return _context.Plan.Any(e => e.ID == id);
        }
    }
}
