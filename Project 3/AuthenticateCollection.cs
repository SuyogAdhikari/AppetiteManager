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
    public partial class AuthenticateCollection : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource = localhost; username = root; password=; database = Login");
        int i;
        public AuthenticateCollection()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {

            if (PasswordBox.Text == "Authentication Code")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {

            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Authentication Code";
                PasswordBox.ForeColor = Color.DimGray;
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AuthenticationCode where Code='" + PasswordBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "Authentication Failed !!";
            }

            else
            {
                this.Hide();
                DashBoard DB = new DashBoard();
                DB.Show();
            }


            con.Close();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword UP = new UpdatePassword();
            this.Hide();
            UP.Show();
        }

        private void GotoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard DB = new DashBoard();
            DB.Show();
        }
    }
}
