using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

    public class MegaDeskRazorPagesDeskQuoteContext : DbContext
    {
        public MegaDeskRazorPagesDeskQuoteContext (DbContextOptions<MegaDeskRazorPagesDeskQuoteContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazorPages.Models.DeskQuote> DeskQuote { get; set; }
    }
