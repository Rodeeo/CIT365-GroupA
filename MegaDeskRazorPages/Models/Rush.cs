using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskRazorPages.Models
{
    public class Rush
    {
        public int ID { get; set; }

        [Required]
        public int Days { get; set; }
        public string Description { get; set; }
    }
}