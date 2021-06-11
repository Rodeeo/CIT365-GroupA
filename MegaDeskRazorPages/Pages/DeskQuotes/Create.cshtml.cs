using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazorPagesDeskQuoteContext _context;
        private readonly MegaDeskRazorPagesDesktopMaterialContext _materialContext;
        private readonly MegaDeskRazorPagesRushContext _rushContext;

        public CreateModel(MegaDeskRazorPagesDeskQuoteContext context, MegaDeskRazorPagesDesktopMaterialContext materialContext, MegaDeskRazorPagesRushContext rushContext)
        {
            _context = context;
            _materialContext = materialContext;
            _rushContext = rushContext;

            IQueryable<DesktopMaterial> materialQuery = from m in _materialContext.DesktopMaterial
                                                        orderby m.Material
                                                        select m;

            IQueryable<Rush> rushQuery = from r in _rushContext.Rush
                                         select r;

            Materials = new SelectList(materialQuery.Distinct().ToList(), nameof(DesktopMaterial.ID), nameof(DesktopMaterial.Material));
            Rushes = new SelectList(rushQuery.Distinct().ToList(), nameof(Rush.ID), nameof(Rush.Description));
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public SelectList Materials { get; set; }
        public SelectList Rushes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
