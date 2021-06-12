using MegaDeskRazorPages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDeskRazorPages.Models
{
    public static class SeedRushData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorContext>>()))
            {
                // Look for any movies.
                if (context.Rush.Any())
                {
                    return;   // DB has been seeded
                }

                context.Rush.AddRange(
                    new Rush
                    {
                        Days = 3,
                        Description = "Rush - 3 Days"
                    },
                    new Rush
                    {
                        Days = 5,
                        Description = "Rush - 5 Days"
                    },
                    new Rush
                    {
                        Days = 7,
                        Description = "Rush - 7 Days"
                    },
                    new Rush
                    {
                        Days = 14,
                        Description = "Rush - 14 Days"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}