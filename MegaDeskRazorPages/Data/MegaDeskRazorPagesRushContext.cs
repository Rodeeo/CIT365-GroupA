using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

    public class MegaDeskRazorPagesRushContext : DbContext
    {
        public MegaDeskRazorPagesRushContext (DbContextOptions<MegaDeskRazorPagesRushContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazorPages.Models.Rush> Rush { get; set; }
    }
