using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.DesktopMaterials
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazorPagesDesktopMaterialContext _context;

        public IndexModel(MegaDeskRazorPagesDesktopMaterialContext context)
        {
            _context = context;
        }

        public IList<DesktopMaterial> DesktopMaterial { get;set; }

        public async Task OnGetAsync()
        {
            DesktopMaterial = await _context.DesktopMaterial.ToListAsync();
        }
    }
}
