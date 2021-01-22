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
    public partial class FoodItemDisplay : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
        public FoodItemDisplay()
        {
            InitializeComponent();
        }

        public FoodItemDisplay (String name, String description, String path, String price)
        {
            InitializeComponent();
            name1.Text = name;
            label6.Text = description;
            button1.Text =  price;
            if (System.IO.File.Exists(path))
            {
                Bitmap bitmap = new Bitmap(path);
                FoodImage.ImageLocation = path;
            }
        }        

        public String getText()
        {
            return name1.Text;
        }

    }
}
