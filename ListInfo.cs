using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokedex
{
    class Items
    {
        public string itemName { get; set; }
        public int itemCost { get; set; }
        public int itemFlingPower { get; set; }
    }

    class Moves
    {
        public string moveName { get; set; }
        public int movePowerPoint { get; set; }
        public string moveType { get; set; }
        public string moveEffect { get; set; }
    }

    class Types
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int Exp { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}