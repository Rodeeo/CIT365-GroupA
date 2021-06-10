using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorDesk_App.Data;

namespace RazorDesk_App.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorDesk_AppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorDesk_AppContext>>()))
            {
                // Look for any movies.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        FirstName = "Harry",
                        LastName = "Potter",
                        Width = 25,
                        Depth = 13,
                        NumberOfDrawers = 3,
                        DesktopMaterial = DesktopMaterial.Laminate,
                        QuoteDate = DateTime.Parse("2021-06-01"),
                        RushDays = 0,
                    },
                    new DeskQuote
                    {
                        FirstName = "Luke",
                        LastName = "Skywalker ",
                        Width = 35,
                        Depth = 33,
                        NumberOfDrawers = 5,
                        DesktopMaterial = DesktopMaterial.Oak,
                        QuoteDate = DateTime.Parse("2021-06-02"),
                        RushDays = 3,
                    },
                    new DeskQuote
                    {
                        FirstName = "Frodo",
                        LastName = "Bagins",
                        Width = 45,
                        Depth = 23,
                        NumberOfDrawers = 3,
                        DesktopMaterial = DesktopMaterial.Veneer,
                        QuoteDate = DateTime.Parse("2021-06-03"),
                        RushDays = 5,
                    }, new DeskQuote
                    {
                        FirstName = "Jean Luc",
                        LastName = "Pickard",
                        Width = 65,
                        Depth = 48,
                        NumberOfDrawers = 3,
                        DesktopMaterial = DesktopMaterial.Pine,
                        QuoteDate = DateTime.Parse("2021-06-04"),
                        RushDays = 7,
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
    
