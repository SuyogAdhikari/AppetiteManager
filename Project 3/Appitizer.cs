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
    public partial class Appitizer : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        List<String> foodlist;
        List<String> fooddes;
        List<String> imagepath;
        List<String> FoodPrice;
        List<Menu> originalist;
        List<Menu> filteredlist;

        public struct thefood
        {
            public string name, description, path, Itemprice;
        }

        thefood[] food = new thefood[500];


        public Appitizer()
        {
            InitializeComponent();
            foodlist = new List<string>();
            fooddes = new List<string>();
            imagepath = new List<string>();
            FoodPrice = new List<string>();
            originalist = new List<Menu>();
            filteredlist = new List<Menu>();

            string SelectQuery = "SELECT *FROM appititemanager1.fooditem where foodtype='Appetizer'";
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
                Menu panel = new Menu();
                food[x].name = name;
                x++;
            }

            x = 0;
            foreach (String description in fooddes)
            {
                Menu panel = new Menu();
                food[x].description = description;
                x++;
            }

            x = 0;
            foreach (String path in imagepath)
            {
                Menu panel = new Menu();
                food[x].path = path;
                x++;
            }

            x = 0;
            foreach (String ItemPrice in FoodPrice)
            {
                Menu panel = new Menu();
                food[x].Itemprice = ItemPrice;
                x++;
            }

            for (int y = 0; y < fooddes.Count; y++)
            {
                Menu panel = new Menu(food[y].name, food[y].description, food[y].path, food[y].Itemprice);
                originalist.Add(panel);
                filteredlist.Add(panel);
            }

            populateitem();

        }

        private void populateitem()
        {
            AppitizerDisplay.Controls.Clear();
            foreach (Menu panel in filteredlist)
            {
                AppitizerDisplay.Controls.Add(panel);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            filteredlist.Clear();
            foreach(Menu panel in originalist)
            {
                String text = Search.Text;
                if(String.IsNullOrEmpty(text))
                {
                    foreach (Menu p in originalist)
                        filteredlist.Add(p);
                }
                else if(panel.getText().ToString().ToLower().Contains(Search.Text.ToLower()))
                {
                    filteredlist.Add(panel);
                }

            }
            populateitem();
        }
    }
}
