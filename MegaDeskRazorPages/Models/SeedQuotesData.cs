// using MegaDeskRazorPages.Models;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using System;
// using System.Linq;

// namespace MegaDeskRazorPages.Models
// {
//     public static class SeedQuotesData
//     {
//         public static void Initialize(IServiceProvider serviceProvider)
//         {
//             using (var context = new MegaDeskRazorPagesDeskQuoteContext(
//                 serviceProvider.GetRequiredService<
//                     DbContextOptions<MegaDeskRazorPagesDeskQuoteContext>>()))
//             {
//                 // Look for any movies.
//                 if (context.DeskQuote.Any())
//                 {
//                     return;   // DB has been seeded
//                 }

//                 DesktopMaterial material = new DesktopMaterial();
//                 material.ID = 1;
//                 material.Material = "Oak";
//                 material.Image = "oak.jpg";

//                 Desk desk = new Desk();
//                 desk.Depth = 40;
//                 desk.Width = 60;
//                 desk.NumDrawers = 6;
//                 desk.Material = material;

//                 Rush rush = new Rush();
//                 rush.ID = 1;
//                 rush.Days = 3;
//                 rush.Description = "Rush - 3 Days";


//                 context.DeskQuote.AddRange(
//                     new DeskQuote
//                     {
//                         CustomerName = "Daniel Melo",
//                         Rush = rush,
//                         DateEntry = DateTime.Now,
//                         TotalCost = 1000,
//                         Desk = desk
//                     }
//                 );
//                 context.SaveChanges();
//             }
//         }
//     }
// }