using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class MoveInfo
    {
        public int pp;
        public Type type;
        //public float effect_chance;
        public EffectContainer[] effect_entries;
    }
}