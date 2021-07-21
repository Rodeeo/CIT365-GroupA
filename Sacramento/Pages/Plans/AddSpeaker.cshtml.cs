using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sacramento.Data;
using Sacramento.Models;

namespace Sacramento.Pages.Plans
{
    public class AddSpeakerModel : PageModel
    {
        private readonly Sacramento.Data.SacramentoContext _context;

        public AddSpeakerModel(Sacramento.Data.SacramentoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Plan Plan { get; set; }

        [BindProperty]
        public string SpeakerName { get; set; }

        [BindProperty]
        public string Subject { get; set; }

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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            Plan = await _context.Plan
                .Include(p => p.ClosingSong)
                .Include(p => p.ConductingLeader)
                .Include(p => p.IntermediateSong)
                .Include(p => p.OpeningSong)
                .Include(p => p.PresidingLeader)
                .Include(p => p.SacramentHymn).FirstOrDefaultAsync(m => m.ID == id);

            List<Speaker> speakers = new List<Speaker>();

            Speaker speaker = new Speaker { Name=SpeakerName, Subject=Subject };
            speakers.Add(speaker);

            if(Plan.Speakers == null)
            {
                Plan.Speakers = speakers;
            }
            else
            {
                Plan.Speakers.Add(speaker);
            }


            _context.Attach(Plan).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool PlanExists(int id)
        {
            return _context.Plan.Any(e => e.ID == id);
        }
    }
}
