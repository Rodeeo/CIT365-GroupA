using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

    public class MegaDeskRazorPagesDesktopMaterialContext : DbContext
    {
        public MegaDeskRazorPagesDesktopMaterialContext (DbContextOptions<MegaDeskRazorPagesDesktopMaterialContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazorPages.Models.DesktopMaterial> DesktopMaterial { get; set; }
    }
