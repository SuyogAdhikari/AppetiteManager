using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
namespace Appitite_Manager_9
{
    public partial class SpecialEdit : UserControl
    {
       static  string[] price = new string[3];
        static string[] fdes = new string[3];
        static  string[] fname = new string[3];
        static  string[] fimg = new string[3];
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
        public SpecialEdit()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname[0] = name1.Text;
            fname[1] = label4.Text;
            fname[2] = label7.Text;
            for (int i=0;i<3;i++)
            {
                string SelectQuery = "UPDATE appititemanager1.fooditem set Forspecial=1 where FoodName='" +fname[i] + "'";
                MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

                MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
                AddConnection.Open();
                MySqlDataReader reader = command1.ExecuteReader();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void SpecialEdit_Load(object sender, EventArgs e)
        {
            //FoodItemDisplay f1=new FoodItemDisplay();
            FoodItemDisplay f = new FoodItemDisplay();

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
            pictureBox0.ImageLocation= fimg[0];
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

        private void pictureBox0_Click(object sender, EventArgs e)
        {
            if (pictureBox0.Image != null)
            {
                string PicPath = "";
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                OFD.Title = "Browse Food Item.";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    PicPath = OFD.FileName.ToString();
                    pictureBox0.ImageLocation = PicPath;
                    string SelectQuery = "SELECT *FROM appititemanager1.fooditem where path='"+PicPath+"'";
                    MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

                     MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
                    AddConnection.Open();
                    MySqlDataReader reader = command1.ExecuteReader();
                
                    while (reader.Read())
                    {
                    
                        name1.Text = reader.GetString("FoodName");
                        label6.Text = reader.GetString("Description");

                        button3.Text = reader.GetString("price");
                    }

                   
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            string SelectQuery = "UPDATE appititemanager1.fooditem set Forspecial=0 where FoodName='"+name1.Text+"'";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();

            name1.Text = "";
            pictureBox0.Controls.Clear();
            label6.Text = "";
            button3.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string SelectQuery = "UPDATE appititemanager1.fooditem set Forspecial=0 where FoodName='" + label4.Text + "'";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();

            label4.Text = "";
            pictureBox1.Controls.Clear();
            label3.Text = "";
            button4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string SelectQuery = "UPDATE appititemanager1.fooditem set Forspecial=0 where FoodName='" + label7.Text + "'";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();

            label7.Text = "";
            pictureBox1.Controls.Clear();
            label5.Text = "";
            button5.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string PicPath = "";
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                OFD.Title = "Browse Food Item.";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    PicPath = OFD.FileName.ToString();
                    pictureBox1.ImageLocation = PicPath;
                    string SelectQuery = "SELECT *FROM appititemanager1.fooditem where path='" + PicPath + "'";
                    MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

                    MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
                    AddConnection.Open();
                    MySqlDataReader reader = command1.ExecuteReader();

                    while (reader.Read())
                    {

                        label4.Text = reader.GetString("FoodName");
                        label3.Text = reader.GetString("Description");

                        button4.Text = reader.GetString("price");
                    }

                    //display in boxes
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                string PicPath = "";
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                OFD.Title = "Browse Food Item.";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    PicPath = OFD.FileName.ToString();
                    pictureBox2.ImageLocation = PicPath;
                    string SelectQuery = "SELECT *FROM appititemanager1.fooditem where path='" + PicPath + "'";
                    MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

                    MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
                    AddConnection.Open();
                    MySqlDataReader reader = command1.ExecuteReader();

                    while (reader.Read())
                    {

                        label7.Text = reader.GetString("FoodName");
                        label5.Text = reader.GetString("Description");

                        button5.Text = reader.GetString("price");
                    }
                }
            }
        }

        private void name1_Click(object sender, EventArgs e)
        {

        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
