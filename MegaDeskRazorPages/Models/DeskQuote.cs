using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskRazorPages.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        public Desk Desk { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime DateEntry { get; set; }
        [Required]

        [Display(Name = "Rush Days")]
        public Rush Rush { get; set; }

        [Display(Name = "Total Cost")]
        public int TotalCost { get; set; }
    }
}