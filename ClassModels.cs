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
        public string location_area_encounters { get; set; }
        public StatContainer[] stats { get; set; }
        public Sprites sprites { get; set; }
        public TypeContainer[] types { get; set; }
        public int weight { get; set; }
        public string url { get; set; }
    }

    class Sprites
    {
        public string front_default { get; set; }
    }

    #region Abilities
    class AbilityContainer
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }


    /* A couple other classes looks identical to this one. 
     * So those classes will inherit the proterties from this class */
    class Ability
    {
        public virtual string name { get; set; }
        public string url { get; set; }
    }
    #endregion

    #region Stats
    class StatContainer
    {
        public int base_stat { get; set; }
        public Stat stat { get; set; }
    }

    class Stat : Ability
    {
    }
    #endregion

    #region Items
    class HeldItems
    {
        public Item item { get; set; }
    }

    class Item : Ability
    {

    }

    class ItemInfo
    {
        public int cost { get; set; }
        public int fling_power { get; set; }
    }
    #endregion

    #region Moves
    class MoveInfo
    {
        public int pp { get; set; }
        public Type type { get; set; }
        //public int effect_chance { get; set; }
        public EffectContainer[] effect_entries { get; set; }
    }

    class MoveContainer
    {
        public Move move { get; set; }
    }

    class Move : Ability
    {
    }

    class EffectContainer
    {
        public string effect { get; set; }
    }
    #endregion

    #region Area Encounters

    class Encounter
    {
        public Location location_area { get; set; }
    }

    class Location : Ability
    {
    }

    #endregion

    #region TypeSearch
    class TypeInfo
    {
        public PokemonContainer[] pokemon { get; set; }
    }

    class PokemonContainer
    {
        public PokeInfo pokemon { get; set; }
        public int slot { get; set; }
    }

    class PokeInfo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    class TypeContainer
    {
        public int slot { get; set; }
        public Type type { get; set; }
    }

    class Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    #endregion
}
