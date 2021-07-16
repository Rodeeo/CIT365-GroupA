﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Sacramento.Data.SacramentoContext _context;

        public IndexModel(Sacramento.Data.SacramentoContext context)
        {
            _context = context;
        }

        public IList<Hymn> Hymn { get;set; }

        public async Task OnGetAsync()
        {
            Hymn = await _context.Hymn.ToListAsync();
        }
    }
}
