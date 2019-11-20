using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class List
    {
        #region RestSharp
        RestClient client = new RestClient("https://pokeapi.co/api/v2/");
        RestRequest request;
        IRestResponse response;
        #endregion

        private ItemInfo itemInfo;
        private MoveInfo moveInfo;

        #region Lists
        private List<Stats> stats;
        private List<Abilities> abilities;
        private List<Items> items;
        private List<Moves> moves;
        #endregion

        #region Properties 

        // Public properties that encapsulates the lists above 

        public List<Stats> GetStats {
            get
            {
                return stats;
            }
            private set { } 
        }
        public List<Abilities> GetAbilities {
            get
            {
                return abilities;
            }
            private set { }
        }
        public List<Items> GetItems {
            get
            {
                return items;
            }
            private set { }
        }
        public List<Moves> GetMoves {
            get
            {
                return moves;
            }
            private set { }
        }
        #endregion

        public List(Pokemon poke) // A constructor that sets the lists when instantiated
        {
            stats = GetStatList(poke);
            abilities = GetAbilityList(poke);
            items = GetItemList(poke);
            moves = GetMoveList(poke);
        }

        // These methods return lists of objects used to populate the listViews

        private List<Stats> GetStatList(Pokemon poke)
        {
            var list = new List<Stats>();

            /* Foreach StatContainer (which is a class) in poke.stats (which is an array in the Pokemon class),
             * a new instantiation of the "Stats" class with the values from the StatContainer classes in the 
             * array will be added to the list. The values in the StatContainer is what we got from the api request
             * the methods below are very similar to this one but they use diffrent classes since they retrive diffrent
             * information from the api request */

            foreach (StatContainer s in poke.stats)
            {
                /* none of the names for the pokemon, moves, abilities, etc in the pokemon api have capital first letters
                 * and some of them have dashes insted of spaces so a created a method called "NameToUpper" that makes the 
                 * fist letter in the names capital and replaces the dashes with spaces to make it look nicer */

                list.Add(new Stats() { statName = Pokedex.NameToUpper(s.stat.name), statValue = s.base_stat });
            }

            return list;
        }

        private List<Abilities> GetAbilityList(Pokemon poke) 
        {
            var list = new List<Abilities>();

            foreach (AbilityContainer a in poke.abilities)
            {
                list.Add(new Abilities() { abilityName = Pokedex.NameToUpper(a.ability.name), abilityHidden = a.is_hidden, abilitySlot = a.slot });
            }

            return list;
        }

        private List<Items> GetItemList(Pokemon poke)
        {
            var list = new List<Items>();

            foreach (HeldItems h in poke.held_items)
            {
                string[] url = h.item.url.Split('/');
                request = new RestRequest("item/" + url[6]);
                response = client.Get(request);
                itemInfo = JsonConvert.DeserializeObject<ItemInfo>(response.Content);
                list.Add(new Items() { itemName = Pokedex.NameToUpper(h.item.name), itemCost = itemInfo.cost, itemFlingPower = itemInfo.fling_power });
            }

            return list;
        }

        private List<Moves> GetMoveList(Pokemon poke)
        {
            var list = new List<Moves>();

            foreach (MoveContainer m in poke.moves)
            {
                string[] url = m.move.url.Split('/');
                request = new RestRequest("move/" + url[6]);
                response = client.Get(request);
                moveInfo = JsonConvert.DeserializeObject<MoveInfo>(response.Content);
                list.Add(new Moves() { moveName = Pokedex.NameToUpper(m.move.name), moveEffect = moveInfo.effect_entries[0].effect, movePowerPoint = moveInfo.pp, moveType = moveInfo.type.name });
            }

            return list;
        }
    }
}
