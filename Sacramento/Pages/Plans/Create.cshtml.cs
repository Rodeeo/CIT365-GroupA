using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sacramento.Data;
using Sacramento.Models;

namespace Sacramento.Pages.Plans
{
    public class CreateModel : PageModel
    {
        private readonly Sacramento.Data.SacramentoContext _context;

        public CreateModel(Sacramento.Data.SacramentoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MeetingDate"] = DateTime.Now.ToString("yyyy-MM-dd");
            ViewData["ClosingSongID"] = new SelectList(_context.Hymn, "ID", "Name");
            ViewData["ConductingLeaderID"] = new SelectList(_context.Leader, "ID", "Name");
            ViewData["IntermediateSongID"] = new SelectList(_context.Hymn, "ID", "Name");
            ViewData["OpeningSongID"] = new SelectList(_context.Hymn, "ID", "Name");
            ViewData["PresidingLeaderID"] = new SelectList(_context.Leader, "ID", "Name");
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymn, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Plan Plan { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Plan.Add(Plan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
