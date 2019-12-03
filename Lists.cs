using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Lists
    {
        #region RestSharp
        RestClient client = new RestClient("https://pokeapi.co/api/v2/");
        RestRequest request;
        IRestResponse response;
        #endregion

        private ItemInfo itemInfo;
        private MoveInfo moveInfo;
        private Encounters[] encounterInfo;

        #region Lists
        private List<Items> items;
        private List<Moves> moves;
        private List<EncounterArea> encounters;
        #endregion

        #region Properties 

        // Public properties that encapsulates the lists above 

        public List<Items> GetItems
        {
            get
            {
                return items;
            }
            private set { }
        }
        public List<Moves> GetMoves
        {
            get
            {
                return moves;
            }
            private set { }
        }
        public List<EncounterArea> GetEncounterLocations
        {
            get
            {
                return encounters;
            }
            private set { }
        }
        #endregion

        public Lists(Pokemon poke) // A constructor that sets the lists when instantiated
        {
            if (poke != null)
            {
                items = GetItemList(poke);
                moves = GetMoveList(poke);
                encounters = GetEcounterLocationList(poke);
            }
        }

        // These methods return lists of objects used to populate the listViews

        private List<Items> GetItemList(Pokemon poke)
        {
            var list = new List<Items>();

            /* Foreach StatContainer (which is a class) in poke.stats (which is an array in the Pokemon class),
             * a new instantiation of the "Stats" class with the values from the StatContainer classes in the 
             * array will be added to the list. The values in the StatContainer is what we got from the api request
             * the methods below are very similar to this one but they use diffrent classes since they retrive diffrent
             * information from the api request */

            foreach (HeldItems h in poke.held_items)
            {

                /* none of the names for the pokemon, moves, abilities, etc in the pokemon api have capital first letters
                 * and some of them have dashes insted of spaces so a created a method called "NameToUpper" that makes the 
                 * fist letter in the names capital and replaces the dashes with spaces to make it look nicer */

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

                /*
                if (moveInfo.effect_entries[0].effect.Contains("$effect_chance"))
                {
                    list.Add(new Moves() { moveName = Pokedex.NameToUpper(m.move.name), moveEffect = GetEffectChance(moveInfo.effect_entries[0].effect, moveInfo.effect_chance), movePowerPoint = moveInfo.pp, moveType = moveInfo.type.name });
                }
                else
                {
                    list.Add(new Moves() { moveName = Pokedex.NameToUpper(m.move.name), moveEffect = moveInfo.effect_entries[0].effect, movePowerPoint = moveInfo.pp, moveType = moveInfo.type.name });
                }
                */
            }

            return list;
        }

        private List<EncounterArea> GetEcounterLocationList(Pokemon poke)
        {
            var list = new List<EncounterArea>();

            string[] url = poke.location_area_encounters.Split('/');
            request = new RestRequest("pokemon/" + url[6] + "/" + url[7]);
            response = client.Get(request);
            encounterInfo = JsonConvert.DeserializeObject<Encounters[]>(response.Content);
            foreach (Encounters e in encounterInfo)
            {
                list.Add(new EncounterArea() { locationName = Pokedex.NameToUpper(e.location_area.name) });
            }

            return list;
        }

        private string GetEffectChance(string effect, int effect_chance)
        {
            string result;

            result = effect.Replace("$effect_chance", effect_chance.ToString());

            return result;
        }
    }
}
