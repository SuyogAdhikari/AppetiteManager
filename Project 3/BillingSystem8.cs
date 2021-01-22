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
    public partial class BillingSystem8 : Form
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        public BillingSystem8()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=appititemanager1;username = root;password="; //Set your MySQL connection string here.
            string query = "Select * from appititemanager1.table8"; // set query to fetch data "Select * from  tabelname"; 
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

        private void BillingSystem8_Load(object sender, EventArgs e)
        {

        }
    }
}
