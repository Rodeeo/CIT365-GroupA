using MegaDeskRazorPages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDeskRazorPages.Models
{
    public static class SeedImageData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorContext>>()))
            {
                // Look for any movies.
                if (context.MaterialImage.Any())
                {
                    return;   // DB has been seeded
                }

                context.MaterialImage.AddRange(
                    new MaterialImage
                    {
                        Path = "oak.jpg",
                        Description = "Oak"
                    },
                    new MaterialImage
                    {
                        Path = "laminate.jpg",
                        Description = "Laminate"
                    },
                    new MaterialImage
                    {
                        Path = "pine.jpg",
                        Description = "Pine"
                    },
                    new MaterialImage
                    {
                        Path = "rosewood.jpg",
                        Description = "Rosewood"
                    },
                    new MaterialImage
                    {
                        Path = "venner.jpg",
                        Description = "Venner"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}