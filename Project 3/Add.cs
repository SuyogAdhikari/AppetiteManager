using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Appitite_Manager_9
{
    public partial class Add : UserControl
    {
        static string ImagePicPath;
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
        public Add()
        {
            InitializeComponent();
        }

        private void BrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            
            OFD.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            OFD.Title = "Browse Food Item.";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string PicPath = OFD.FileName.ToString();
                FoodImage.ImageLocation = PicPath;
                ImagePicPath = PicPath;

            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            

            if (FoodName.Text == "" || FoodPrice.Text == ""|| comboBox1.SelectedIndex ==-1)
                {
                    Confirmed.Text = "Insertion Failed";
                }
                else
                {
                Bitmap bitmap = new Bitmap(ImagePicPath);
                ImagePicPath = "Images/" + FoodName.Text + ".jpg";
                bitmap.Save(ImagePicPath, ImageFormat.Jpeg);
                string selected = comboBox1.SelectedItem.ToString();

                string insertQuery = "INSERT INTO appititemanager1.fooditem(foodname,price,description,path,Foodtype) VALUES('" + FoodName.Text + "','" + FoodPrice.Text.ToString() + "', '" + FoodDescription.Text + "','" + ImagePicPath + "','" + selected + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Confirmed.Text = "Item Inserted";
                    }

                    else
                    {
                        Confirmed.Text = "Item Insertion Failed";
                    }
                    AddConnection.Close();
                }
        }    

       

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}

