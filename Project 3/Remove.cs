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
    public partial class FoodName : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
        public FoodName()
        {
            InitializeComponent();
        }

       

        private void AddItem_Click(object sender, EventArgs e)
        {
           

            string SelectQuery = "Delete FROM  appititemanager1.fooditem where FoodName = '" + comboBox1.Text + "'";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            command1.ExecuteNonQuery();
            AddConnection.Close();


        }   

        private void Remove_Load(object sender, EventArgs e)
        {
          

            string SelectQuery = "SELECT FoodName FROM appititemanager1.fooditem";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
            MySqlCommand command1 = new MySqlCommand(SelectQuery, AddConnection);
            AddConnection.Open();
            MySqlDataReader reader = command1.ExecuteReader();
            string name1;
            while (reader.Read())
            {

               name1 = reader.GetString("FoodName");
                comboBox1.Items.Add(name1);
                comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox1.AutoCompleteCustomSource.Add(name1);                
                
            }
        }
    }
}
