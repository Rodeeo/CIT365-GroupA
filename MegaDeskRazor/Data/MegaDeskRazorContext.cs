using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;

public class MegaDeskRazorContext : DbContext
{
    public MegaDeskRazorContext(DbContextOptions<MegaDeskRazorContext> options)
        : base(options)
    {
    }

    public DbSet<MegaDeskRazorPages.Models.DesktopMaterial> DesktopMaterial { get; set; }

    public DbSet<MegaDeskRazorPages.Models.Rush> Rush { get; set; }

    public DbSet<MegaDeskRazorPages.Models.Desk> Desk { get; set; }

    public DbSet<MegaDeskRazorPages.Models.DeskQuote> DeskQuote { get; set; }

    public DbSet<MegaDeskRazorPages.Models.MaterialImage> MaterialImage { get; set; }
}
