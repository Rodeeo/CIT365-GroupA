using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Sacramento.Models
{
    public static class SeedDataHymns
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentoContext>>()))
            {
                // Look for any movies.
                if (context.Hymn.Any())
                {
                    return;   // DB has been seeded
                }

                context.Hymn.AddRange(
                    new Hymn
                    {
                        Number = 1,
                        Name = "The Morning Breaks",
                    },
                    new Hymn
                    {
                        Number = 2,
                        Name = "The Spirit of God",
                    },
                    new Hymn
                    {
                        Number = 3,
                        Name = "Now Let Us Rejoice",
                    },
                    new Hymn
                    {
                        Number = 4,
                        Name = "Truth Eternal",
                    },
                    new Hymn
                    {
                        Number = 5,
                        Name = "High on the MOuntain Top",
                    },
                    new Hymn
                    {
                        Number = 6,
                        Name = "Redeemer of Israel",
                    },
                    new Hymn
                    {
                        Number = 7,
                        Name = "Israel, Israel, Gos is Calling",
                    },
                    new Hymn
                    {
                        Number = 8,
                        Name = "Awake and Arise",
                    },
                    new Hymn
                    {
                        Number = 9,
                        Name = "Come, Rejoice",
                    },
                    new Hymn
                    {
                        Number = 10,
                        Name = "Come, Sing to the Lord",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}