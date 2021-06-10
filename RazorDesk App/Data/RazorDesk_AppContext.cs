using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorDesk_App.Models;

namespace RazorDesk_App.Data
{
    public class RazorDesk_AppContext : DbContext
    {
        public RazorDesk_AppContext (DbContextOptions<RazorDesk_AppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorDesk_App.Models.DeskQuote> DeskQuote { get; set; }
    }
}
