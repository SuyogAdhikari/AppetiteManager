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
    public partial class FoodItem : UserControl
    {
        public static string FoodImagePath;
        public static FoodItem _instance;
        public static FoodItem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FoodItem();
                return _instance;

            }
        }
        public FoodItem()
        {
            InitializeComponent();
        }

        private void FoodImage_Click(object sender, EventArgs e)
        {
            
            string PicPath = "";
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            OFD.Title = "Browse Food Item.";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                PicPath = OFD.FileName.ToString();
                FoodImage.ImageLocation = PicPath;
               // label6.Text = PicPath;
              
                string SelectQuery = "SELECT *FROM appititemanager1.fooditem where path='" + PicPath + "'";
                MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
                
                MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
                AddConnection.Open();
                MySqlDataReader reader = command1.ExecuteReader();
                string data2;
                while (reader.Read())
                {
                    data2= reader.GetString("FoodName");
                    name1.Text = data2;
                    data2 = reader.GetString("Price");
                    button1.Text = "RS: "+data2;
                    data2 = reader.GetString("Description");
                    label6.Text = data2;
                }

            }
            //                        
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            string foodn = name1.Text;
            
            string SelectQuery = "UPDATE appititemanager1.fooditem set ForSpecial=0 where FoodName='" + foodn + "'";

            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();
            this.Hide();
        }
    }
}
