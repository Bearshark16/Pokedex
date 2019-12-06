using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
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
        Lists lists;

        Dictionary<string, int> stats = new Dictionary<string, int>();

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Too stop watches that that messures the two main parts of my code. The part that instantiates the classes and the part that prints the information contained within them
            var watch = new System.Diagnostics.Stopwatch();
            var watch2 = new System.Diagnostics.Stopwatch();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
            hpProgressBar.Minimum = 0;
            hpProgressBar.Maximum = 200;
            attackProgressBar.Minimum = 0;
            attackProgressBar.Maximum = 200;
            speedProgressBar.Minimum = 0;
            speedProgressBar.Maximum = 200;
            defenseProgressBar.Minimum = 0;
            defenseProgressBar.Maximum = 200;
            sdProgressBar.Minimum = 0;
            saProgressBar.Maximum = 200;

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

            lists = new Lists(poke);

            List<Items> items = null;
            List<Moves> moves = null;
            List<AbilityPrint> abilities = null;
            List<EncounterArea> locations = null;

            if (poke != null)
            {
                items = lists.GetItems;
                moves = lists.GetMoves;
                abilities = lists.GetAbilities;
                locations = lists.GetEncounterLocations;
            }

            foreach(StatContainer s in poke.stats)
            {
                stats.Add(s.stat.name, s.base_stat);
            }

            watch.Stop();

            // Populates the lables, pictureboxes and progressbar with info retrived form the api request.

            watch2.Start();

            PrintLables(watch);

            PrintListViews(items, moves, locations, abilities);

            watch2.Stop();

            PrintTime.Text = "Printing: " + $"Execution Time: {watch2.ElapsedMilliseconds / 1000} sec";
        }

        private void PrintListViews(List<Items> items, List<Moves> moves, List<EncounterArea> locations, List<AbilityPrint> abilities)
        {
            /*StatListView.Items.Clear();

            foreach (var s in poke.stats)
            {
                // An array containing the info in my chosen order
                var listRow = new ArrayList() { NameToUpper(s.stat.name), s.base_stat.ToString() };
                // An instance of the ListViewItem class which uses an array of strings to represent the subitems in the listView. The array used is the one i made above 
                var listItem = new ListViewItem((string[])listRow.ToArray(typeof(string)));
                listItem.Tag = s;

                // Adds the ListViewItem to the ListView
                StatListView.Items.Add(listItem);
            }*/

            AbilityListView.Items.Clear();

            foreach (var a in abilities)
            {
                var listRow = new ArrayList() { a.abilityName, a.abilityEffect };
                var listItem = new ListViewItem((string[])listRow.ToArray(typeof(string)));
                listItem.Tag = a;

                AbilityListView.Items.Add(listItem);
            }

            InventoryListView.Items.Clear();

            foreach (var i in items)
            {
                var listRow = new ArrayList() { i.itemName, i.itemCost.ToString(), i.itemFlingPower.ToString() };
                var listItem = new ListViewItem((string[])listRow.ToArray(typeof(string)));
                listItem.Tag = i;

                InventoryListView.Items.Add(listItem);
            }

            MoveListView.Items.Clear();

            foreach (var m in moves)
            {
                var listRow = new ArrayList() { m.moveName, m.movePowerPoint.ToString(), m.moveType, m.moveEffect };
                var listItem = new ListViewItem((string[])listRow.ToArray(typeof(string)));
                listItem.Tag = m;

                MoveListView.Items.Add(listItem);
            }

            locationListView.Items.Clear();

            foreach (var l in locations)
            {
                var listRow = new ArrayList() { l.locationName };
                var listItem = new ListViewItem((string[])listRow.ToArray(typeof(string)));
                listItem.Tag = l;

                locationListView.Items.Add(listItem);
            }
        }

        private void PrintLables(System.Diagnostics.Stopwatch watch)
        {
            APITime.Text = "Instantiation: " + $"Execution Time: {watch.ElapsedMilliseconds / 1000} sec";
            pokemonName.Text = NameToUpper(poke.name);
            expLable.Text = "Exp: " + poke.base_experience.ToString();
            label10.Text = "Weight: " + poke.weight;
            label11.Text = "Height: " + poke.height;
            progressBar1.Value = poke.base_experience;
            if (poke.types.Length > 0)
            {
                List<string> values = new List<string>();
                foreach (TypeContainer t in poke.types)
                {
                    values.Add(t.type.name);
                }
                string type = string.Join(" - ", values.ToArray());
                label9.Text = type;
            }
            else
            {
                label9.Text = "Type: " + poke.types[0].type.name;
            }
            pictureBox1.ImageLocation = poke.sprites.front_default;
            stats.TryGetValue("hp", out int hp);
            hpProgressBar.Value = hp;
            stats.TryGetValue("attack", out int attack);
            attackProgressBar.Value = attack;
            stats.TryGetValue("attack", out int defense);
            defenseProgressBar.Value = defense;
            stats.TryGetValue("attack", out int speed);
            speedProgressBar.Value = speed;
            stats.TryGetValue("attack", out int sd);
            sdProgressBar.Value = sd;
            stats.TryGetValue("attack", out int sa);
            saProgressBar.Value = sa;
            total.Text = (hp + attack + defense + speed + sd + sa).ToString();

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


        #region bullshit
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PokemonName_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
