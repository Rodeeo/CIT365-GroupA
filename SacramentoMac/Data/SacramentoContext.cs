using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sacramento.Models;

public class SacramentoContext : DbContext
{
    public SacramentoContext(DbContextOptions<SacramentoContext> options)
        : base(options)
    {
    }

    public DbSet<Sacramento.Models.Hymn> Hymn { get; set; }

    public DbSet<Sacramento.Models.Leader> Leader { get; set; }

    public DbSet<Sacramento.Models.Person> Person { get; set; }

    public DbSet<Sacramento.Models.Speaker> Speaker { get; set; }

    public DbSet<Sacramento.Models.Plan> Plan { get; set; }

}
