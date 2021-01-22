using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Appitite_Manager_9
{
    public partial class BillingSystem1 : Form
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        public BillingSystem1()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=appititemanager1;username = root;password="; //Set your MySQL connection string here.
            string query = "Select * from appititemanager1.table1"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    updatedata.DataSource = ds.Tables[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO appititemanger1.earning(IemProvided,price) SELECT * FROM appititemanager1.table1";
            MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

            MySqlCommand command1 = new MySqlCommand(str, AddConnection);
            AddConnection.Open();
         //   MySqlDataReader reader = command1.ExecuteReader();
          //  string data2;
            //while (reader.Read())
            //{
            //    MySqlConnection AddConnection1 = new MySqlConnection("datasource=localhost; username=root;password=");

            //    string str1 = "INSERT INTO appititemanager1.earning(IemProvided,price) values('"+reader.GetString("OrderName")+"','" + reader.GetString("price")+"')";
            //    MySqlCommand command2 = new MySqlCommand(str, AddConnection1);
            //    AddConnection1.Open();

            //}


        }
    }
}
