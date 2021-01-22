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

    public partial class MenuDashBoard : UserControl
    {
        static string[] price = new string[3];
        static string[] fdes = new string[3];
        static string[] fname = new string[3];
        static string[] fimg = new string[3];
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        public MenuDashBoard()
        {
            InitializeComponent();
            SpecialEdit MDE = new SpecialEdit();
            DailySpecial.Controls.Add(MDE.DailySpecialEdit);
        }

        private void MenuDashBoard_Load(object sender, EventArgs e)
        {
            string SelectQuery = "SELECT *FROM appititemanager1.fooditem where ForSpecial= '1'";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();

            try
            {
                int i = 0;
                while (reader.Read())
                {
                    fname[i] = reader.GetString("FoodName");
                    price[i] = reader.GetString("Price");
                    fdes[i] = reader.GetString("Description");
                    fimg[i] = reader.GetString("path");
                    i++;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // f1.FoodImage .ImageLocation = fimg[0];
            //  MessageBox.Show(fimg[0]);
            name1.Text = fname[0];
            pictureBox0.ImageLocation = fimg[0];
            label6.Text = fdes[0];
            button3.Text = price[0];

            label4.Text = fname[1];
            pictureBox1.ImageLocation = fimg[1];
            label3.Text = fdes[1];
            button4.Text = price[1];

            label7.Text = fname[2];
            pictureBox2.ImageLocation = fimg[2];
            label5.Text = fdes[2];
            button5.Text = price[2];

        }
    }
}
