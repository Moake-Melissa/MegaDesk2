using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_MelissaMoake
{
    class Desk
    {
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumOfDrawers { get; set; }
        public MaterialType MaterialType { get; set; }

        public const decimal MIN_WIDTH = 24;
        public const decimal MAX_WIDTH = 96;
        public const decimal MIN_DEPTH = 12;
        public const decimal MAX_DEPTH = 48;
    }

    public enum MaterialType
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 150,
        Pine = 50
    };
}
