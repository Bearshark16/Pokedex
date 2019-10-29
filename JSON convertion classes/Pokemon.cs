using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Pokemon
    {
        public AbilityContainer[] abilities { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public HeldItems[] held_items { get; set; }
        public MoveContainer[] moves { get; set; }
        public string name { get; set; }
        public StatContainer[] stats { get; set; }
        public Sprites sprites { get; set; }
        public TypeContainer[] types { get; set; }
        public int weight { get; set; }
        public string url { get; set; }
    }
}
