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

            pokemonName.Text = poke.name;
            heightLable.Text = "Height: " + poke.height.ToString();
            expLable.Text = "Exp: " + poke.base_experience.ToString();

            statListBox.Items.Clear();

            foreach(StatContainer s in poke.stats)
            {
                statListBox.Items.Add(s.stat.name + ": " + s.base_stat + "\n");
            }
        }
    }
}
