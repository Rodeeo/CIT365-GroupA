using MegaDeskRazorPages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDeskRazorPages.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorContext>>()))
            {
                // Look for any movies.
                if (context.DesktopMaterial.Any())
                {
                    return;   // DB has been seeded
                }

                context.DesktopMaterial.AddRange(
                    new DesktopMaterial
                    {
                        Material = "Oak",
                        ImageID = 1,
                        Price = 200
                    },
                    new DesktopMaterial
                    {
                        Material = "Laminate",
                        ImageID = 2,
                        Price = 100
                    },
                    new DesktopMaterial
                    {
                        Material = "Pine",
                        ImageID = 3,
                        Price = 50
                    },
                    new DesktopMaterial
                    {
                        Material = "Rosewood",
                        ImageID = 4,
                        Price = 300
                    },
                    new DesktopMaterial
                    {
                        Material = "Venner",
                        ImageID = 5,
                        Price = 125
                    }
                );
                context.SaveChanges();
            }
        }
    }
}