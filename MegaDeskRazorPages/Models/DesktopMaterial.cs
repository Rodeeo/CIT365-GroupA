// public enum DesktopMaterials
// {
//     Laminate,
//     Oak,
//     Rosewood,
//     Veneer,
//     Pine
// }

using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskRazorPages.Models
{
    public class DesktopMaterial
    {
        public int ID { get; set; }

        [Required]
        public string Material { get; set; }
        public string Image { get; set; }

        // public override string ToString()
        // {
        //     return Material;
        // }
    }
}