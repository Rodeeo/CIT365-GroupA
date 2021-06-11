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
            using (var context = new MegaDeskRazorPagesDesktopMaterialContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorPagesDesktopMaterialContext>>()))
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
                        Image = "oak.jpg"
                    },
                    new DesktopMaterial
                    {
                        Material = "Laminate",
                        Image = "laminate.jpg"
                    },
                    new DesktopMaterial
                    {
                        Material = "Pine",
                        Image = "pine.jpg"
                    },
                    new DesktopMaterial
                    {
                        Material = "Rosewood",
                        Image = "rosewood.jpg"
                    },
                    new DesktopMaterial
                    {
                        Material = "Venner",
                        Image = "venner.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}