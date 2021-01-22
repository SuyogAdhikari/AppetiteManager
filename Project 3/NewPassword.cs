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
    public partial class NewPassword : Form
    {
        MySqlConnection connection = new MySqlConnection(@"datasource = localhost; username = root; password=; database = Login");
        public NewPassword()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "New Password")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {

            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "New Password";
                PasswordBox.ForeColor = Color.DimGray;
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE login.AuthenticationCode SET Code ='" + PasswordBox.Text + "'";
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    UpdateInfo.Text = "Password Updated";
                }

                else
                {
                    UpdateInfo.Text = "Password Update Failed";
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void GotoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard DB = new DashBoard();
            DB.Show();
        }
    }
}
