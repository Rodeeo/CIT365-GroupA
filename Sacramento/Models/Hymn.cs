using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Hymn
    {
        public int ID { get; set; }
        [Range(1, 341)]
        [Required]
        [Display(Name = "Hymn Number")]
        public int Number { get; set; }
        [StringLength(40, MinimumLength = 1)]
        [Required]
        [Display(Name = "Hymn")]
        public string Name { get; set; }
    }
}