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
        public string Material { get; set; }
        // public string Image { get; set; }
        public int ImageID { get; set; }
        public MaterialImage Image { get; set; }
        public int Price { get; set; }

        // public override string ToString()
        // {
        //     return Material;
        // }
    }
}