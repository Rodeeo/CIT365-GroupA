using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sacramento.Data;
using System;
using System.Linq;

namespace Sacramento.Models
{
    public static class SeedDataLeaders
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentoContext>>()))
            {
                // Look for any movies.
                if (context.Leader.Any())
                {
                    return;   // DB has been seeded
                }

                context.Leader.AddRange(
                    new Leader
                    {
                        Name = "Thomas Corner",
                        Phone = "229-456-8750",
                        CallDescription = "Stake President"
                    },
                    new Leader
                    {
                        Name = "John Smith",
                        Phone = "229-456-8751",
                        CallDescription = "Bishop"
                    },
                    new Leader
                    {
                        Name = "Steve Roger",
                        Phone = "229-456-8752",
                        CallDescription = "First Counselor in the Bishopric"
                    },
                    new Leader
                    {
                        Name = "Brendon Smith",
                        Phone = "229-456-8753",
                        CallDescription = "Second Counselor in the Bishopric"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}