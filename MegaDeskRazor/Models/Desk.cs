using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskRazorPages.Models
{
    public class Desk
    {
        public int ID { get; set; }

        [Range(24, 96)]
        [Required]
        public int Width { get; set; }
        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }

        [Range(0, 7)]
        [Required]
        [Display(Name = "Number of Drawers")]
        public int NumDrawers { get; set; }
        [Required]
        public int MaterialID { get; set; }
        public DesktopMaterial Material { get; set; }
    }
}