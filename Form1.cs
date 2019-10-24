using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        Pokemon poke;

        private void searchButton_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("pokemon/" + searchTextBox.Text.ToLower());
            IRestResponse response = client.Get(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                warnngLable.Text = "Pokémon does not exist!";
            }
            else
            {
                warnngLable.Text = null;
                poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            }

            pokemonName.Text = NameToUpper(poke.name);
            heightLable.Text = "Height: " + poke.height.ToString();
            expLable.Text = "Exp: " + poke.base_experience.ToString();
            pokemonImage.ImageLocation = poke.sprites.front_default;

            statListBox.Items.Clear();

            foreach(StatContainer s in poke.stats)
            {
                statListBox.Items.Add(s.stat.name + ": " + s.base_stat);
                statListBox.Items.Add("");
            }

            abilityList.Items.Clear();

            foreach(AbilityContainer a in poke.abilities)
            {
                abilityList.Items.Add(a.ability.name + "\n Hidden: " + a.is_hidden + "\n Slot: " + a.slot);
            }
        }

        static string NameToUpper(string name)
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
        }
    }
}
