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
    public partial class Pokedex : Form
    {
        public Pokedex()
        {
            InitializeComponent();
        }

        RestClient client = new RestClient("https://pokeapi.co/api/v2/");
        RestRequest request;
        IRestResponse response;

        Pokemon poke;
        TypeInfo type;
        List lists;

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Too stop watches that that messures the two main parts of my code. The part that instantiates the classes and the part that prints the information contained within them
            var watch = new System.Diagnostics.Stopwatch();
            var watch2 = new System.Diagnostics.Stopwatch();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;

            watch.Start();

            if (searchTextBox.Text.Any(x => !char.IsLetter(x)) || searchTextBox.Text == null)
            {
                return;
            }
            else
            {
                request = new RestRequest("pokemon/" + searchTextBox.Text.ToLower());
                response = client.Get(request);
            }

            // if the status code of the api response is not "OK" a message is displayed
            // else the the lable used for the error message will be set to null and the 
            // JSON will be deseriliazed and placed in the apropriet variables

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                warnngLable.Text = "Pokémon does not exist!";
            }
            else
            {
                warnngLable.Text = null;
                poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            }

            /* Retrives lists of objects containing information for the listViews in the windows form 
             * and makes secondary api requests for additional information if nessecary. To get all the
             * information i wanted for the items and moves a second api request was needed. I then took 
             * the information from the two requests and placed them i one single class which is then used
             * to create the list items. */

            lists = new List(poke);

            //var stats = lists.GetStats;
            //var abilities = lists.GetAbilities;

            List<Items> items = null;
            List<Moves> moves = null;

            if (poke != null)
            {
                items = lists.GetItems;
                moves = lists.GetMoves;
            }

            watch.Stop();

            // Populates the lables, pictureboxes and progressbar with info retrived form the api request.

            watch2.Start();

            APITime.Text = "Instantiation: " + $"Execution Time: {watch.ElapsedMilliseconds / 1000} sec";
            pokemonName.Text = NameToUpper(poke.name);
            heightLable.Text = "Height: " + poke.height.ToString();
            expLable.Text = "Exp: " + poke.base_experience.ToString();
            progressBar1.Value = poke.base_experience;
            typeLable.Text = "Type: " + poke.types[0].type.name;
            pokemonImage.ImageLocation = poke.sprites.front_default;

            StatListView.Items.Clear();

            foreach (var s in poke.stats)
            {
                // An array containing the info in my chosen order
                var listRow = new string[] { NameToUpper(s.stat.name), s.base_stat.ToString() };
                // An instance of the ListViewItem class which uses an array of strings to represent the subitems in the listView. The array used is the one i made above 
                var listItem = new ListViewItem(listRow);
                listItem.Tag = s;

                // Adds the ListViewItem to the ListView
                StatListView.Items.Add(listItem);
            }

            AbilityListView.Items.Clear();

            foreach (var a in poke.abilities)
            {
                var listRow = new string[] { NameToUpper(a.ability.name), a.is_hidden.ToString(), a.slot.ToString() };
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

            watch2.Stop();

            PrintTime.Text = "Printing: " + $"Execution Time: {watch2.ElapsedMilliseconds / 1000} sec";
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

            TypeDataGridView.Rows.Clear();

            foreach (var t in pokemons)
            {
                TypeDataGridView.Rows.Add(t.ImageUrl, t.Name, t.Exp, t.Height, t.Weight);
            }
        }

        private List<Types> GetPokemonList()
        {
            var list = new List<Types>();

            foreach (PokemonContainer p in type.pokemon)
            {
                string[] url = p.pokemon.url.Split('/');
                request = new RestRequest("pokemon/" + p.pokemon.name);
                response = client.Get(request);
                poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);
                list.Add(new Types() { ImageUrl = p.pokemon.url, Name = p.pokemon.name, Exp = poke.base_experience, Height = poke.height, Weight = poke.weight });
            }

            return list;
        }

        // A method that makes the first letters in names upper case
        public static string NameToUpper(string name)
        {
            List<string> split = new List<string>() { };

            char first;
            string upper;
            string result;

            if (name.Contains(" ") || name.Contains('-'))
            {
                string[] stringSplit = null;

                if (name.Contains(" "))
                {
                    stringSplit = name.Split(' ');
                }
                else if (name.Contains('-'))
                {
                    stringSplit = name.Split('-');
                }

                foreach (string x in stringSplit)
                {
                    first = x[0];
                    upper = first.ToString().ToUpper();
                    string nameCaps = upper + x.Remove(0, 1);
                    split.Add(nameCaps);
                }

                result = string.Join(" ", split.ToArray());
            }
            else
            {
                first = name[0];
                upper = first.ToString().ToUpper();
                result = upper + name.Remove(0, 1);
            }

            return result;
        }
    }
}
