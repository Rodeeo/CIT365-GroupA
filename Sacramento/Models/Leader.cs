
using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Leader : Person
    {
        [Display(Name = "Calling")]
        [StringLength(40, MinimumLength = 1)]
        [Required]
        public string CallDescription { get; set; }
    }
}