using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDesk_Yaona
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int drawers{ get; set; }
        public DesktopMaterial material { get; set; }

        // Restraints
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        public Desk(int width, int depth, int drawers, string material)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = getSurfaceMaterial(material);

        }

        public DesktopMaterial getSurfaceMaterial(string material)
        {
            DesktopMaterial value;

            if (Enum.TryParse<DesktopMaterial>(material, out value))
            {
                return value;
            }

            // sample
            return DesktopMaterial.Rosewood;
        }

        public int getSurfaceArea()
        {
            // return 2 * ((width * width) + (width * depth) + (depth * width));
            return (width * depth);
        }

    }

    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    


}
