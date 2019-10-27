using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RestClient client = new RestClient("https://pokeapi.co/api/v2/");
        RestRequest request;
        IRestResponse response;

        Pokemon poke;
        ItemInfo itemInfo;
        MoveInfo moveInfo;
        TypeInfo type;

        private void searchButton_Click(object sender, EventArgs e)
        {
            request = new RestRequest("pokemon/" + searchTextBox.Text.ToLower());
            response = client.Get(request);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;

            if (searchTextBox.Text.Any(x => !char.IsLetter(x)))
            {
                return;
            }

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                warnngLable.Text = "Pokémon does not exist!";
            }
            else
            {
                warnngLable.Text = null;
                poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            }

            var stats = GetStatList();
            var abilities = GetAbilityList();
            var items = GetItemList();
            var moves = GetMoveList();

            pokemonName.Text = poke.name;
            heightLable.Text = "Height: " + poke.height.ToString();
            expLable.Text = "Exp: " + poke.base_experience.ToString();
            progressBar1.Value = poke.base_experience;
            typeLable.Text = "Type: " + poke.types[0].type.name;
            pokemonImage.ImageLocation = poke.sprites.front_default;

            StatListView.Items.Clear();

            foreach(var s in stats)
            {
                var listRow = new string[] { s.statName, s.statValue.ToString() };
                var listItem = new ListViewItem(listRow);
                listItem.Tag = s;

                StatListView.Items.Add(listItem);
            }

            AbilityListView.Items.Clear();

            foreach(var a in abilities)
            {
                var listRow = new string[] { a.abilityName, a.abilityHidden.ToString(), a.abilitySlot.ToString() };
                var listItem = new ListViewItem(listRow);
                listItem.Tag = a;

                AbilityListView.Items.Add(listItem);
            }

            InventoryListView.Items.Clear();

            foreach (var i in items)
            {
                var listRow = new string[] { i.itemName, i.itemCost.ToString(), i.itemFlingPower.ToString() };
                var listItem = new ListViewItem(listRow);
                listItem.Tag = i;

                InventoryListView.Items.Add(listItem);
            }

            MoveListView.Items.Clear();

            foreach (var m in moves)
            {
                var listRow = new string[] { m.moveName, m.movePowerPoint.ToString(), m.moveType, m.moveEffect };
                var listItem = new ListViewItem(listRow);
                listItem.Tag = m;

                MoveListView.Items.Add(listItem);
            }

        }

        private void TypeSearchButton_Click(object sender, EventArgs e)
        {
            request = new RestRequest("pokemon/" + TypeSearchTextBox.Text.ToLower());
            response = client.Get(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                warningLable2.Text = "Type does not exist!";
            }
            else
            {
                warningLable2.Text = null;
                type = JsonConvert.DeserializeObject<TypeInfo>(response.Content);
            }

            var pokemons = GetPokemonList();
        }

        private List<Pokemon> GetPokemonList()
        {
            throw new NotImplementedException();
        }

        private List<Moves> GetMoveList()
        {
            var list = new List<Moves>();

            foreach (MoveContainer m in poke.moves)
            {
                string[] url = m.move.url.Split('/');
                request = new RestRequest("move/" + url[6]);
                response = client.Get(request);
                moveInfo = JsonConvert.DeserializeObject<MoveInfo>(response.Content);
                list.Add(new Moves() { moveName = m.move.name, moveEffect = moveInfo.effect_entries[0].effect, movePowerPoint = moveInfo.pp, moveType = moveInfo.type.name });
            }

            return list;
        }

        private List<Items> GetItemList()
        {
            var list = new List<Items>();

            foreach (HeldItems h in poke.held_items)
            {
                string[] url = h.item.url.Split('/');
                request = new RestRequest("item/" + url[6]);
                response = client.Get(request);
                itemInfo = JsonConvert.DeserializeObject<ItemInfo>(response.Content);
                list.Add(new Items() { itemName = h.item.name, itemCost = itemInfo.cost, itemFlingPower = itemInfo.fling_power });
            }

            return list;
        }

        private List<Abilities> GetAbilityList()
        {
            var list = new List<Abilities>();

            foreach (AbilityContainer a in poke.abilities)
            {
                list.Add(new Abilities() { abilityName = a.ability.name, abilityHidden = a.is_hidden, abilitySlot = a.slot });
            }

            return list;
        }

        private List<Stats> GetStatList()
        {
            var list = new List<Stats>();

            foreach (StatContainer s in poke.stats)
            {
                list.Add(new Stats() { statName = s.stat.name, statValue = s.base_stat });
            }

            return list;
        }

        /*static string NameToUpper(string name)
        {
            List<string> split = new List<string>() { };

            char first;
            string upper;
            string lower;
            string result = "";
            string nameCaps;

            if (name.Contains("-"))
            {
                name.Replace("-", " ");
            }

            if (name.Contains(" ") == true)
            {
                string[] stringSplit = name.Split(' ');

                foreach (string x in stringSplit)
                {
                    first = x[0];
                    lower = first.ToString();
                    upper = first.ToString();
                    upper = upper.ToUpper();
                    nameCaps = x.Replace(lower, upper);
                    split.Add(nameCaps);
                }

                result = string.Join(" ", split.ToArray());
            }
            else
            {
                first = name[0];
                lower = first.ToString();
                upper = first.ToString();
                upper = upper.ToUpper();
                result = name.Replace(lower, upper);
            }

            return result;
        }*/
    }
}
