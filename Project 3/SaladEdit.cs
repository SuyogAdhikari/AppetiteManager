using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Appitite_Manager_9
{
    public partial class SaladEdit : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        List<String> foodlist;
        List<String> fooddes;
        List<String> imagepath;
        List<String> FoodPrice;
        List<FoodItemDisplay> originalist;
        List<FoodItemDisplay> filteredlist;

        public struct thefood
        {
            public string name, description, path, Itemprice;
        }

        thefood[] food = new thefood[500];

        public SaladEdit()
        {
            InitializeComponent();
            foodlist = new List<string>();
            fooddes = new List<string>();
            imagepath = new List<string>();
            FoodPrice = new List<string>();
            originalist = new List<FoodItemDisplay>();
            filteredlist = new List<FoodItemDisplay>();

            string SelectQuery = "SELECT *FROM appititemanager1.fooditem where foodtype='Salad'";
            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();
            int c = 0;
            int i;

            while (reader.Read())
            {
                food[c].name = reader.GetString("FoodName");
                food[c].description = reader.GetString("Description");
                food[c].path = reader.GetString("Path");
                food[c].Itemprice = reader.GetString("Price");
                c++;
            }
            int total = c;
            for (i = 0; i < total; i++)
            {
                foodlist.Add(food[i].name);
                fooddes.Add(food[i].description);
                imagepath.Add(food[i].path);
                FoodPrice.Add(food[i].Itemprice);
            }

            int x = 0;
            foreach (String name in foodlist)
            {
                FoodItemDisplay panel = new FoodItemDisplay();
                food[x].name = name;
                x++;
            }

            x = 0;
            foreach (String description in fooddes)
            {
                FoodItemDisplay panel = new FoodItemDisplay();
                food[x].description = description;
                x++;
            }

            x = 0;
            foreach (String path in imagepath)
            {
                FoodItemDisplay panel = new FoodItemDisplay();
                food[x].path = path;
                x++;
            }

            x = 0;
            foreach (String ItemPrice in FoodPrice)
            {
                FoodItemDisplay panel = new FoodItemDisplay();
                food[x].Itemprice = ItemPrice;
                x++;
            }

            for (int y = 0; y < fooddes.Count; y++)
            {
                FoodItemDisplay panel = new FoodItemDisplay(food[y].name, food[y].description, food[y].path, food[y].Itemprice);
                originalist.Add(panel);
                filteredlist.Add(panel);
            }

            populateitem();

        }

        private void populateitem()
        {
            foreach (FoodItemDisplay panel in filteredlist)
            {
                SaladDisplay.Controls.Add(panel);
            }
        }
        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "search")
                Search.Text = "";
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
                Search.Text = "search";
        }

        private void SaladEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
