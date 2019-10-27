using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Pokemon
    {
        public AbilityContainer[] abilities;
        public int base_experience;
        public int height;
        public HeldItems[] held_items;
        public MoveContainer[] moves;
        public string name;
        public StatContainer[] stats;
        public Sprites sprites;
        public TypeContainer[] types;
        public string url;
    }
}
