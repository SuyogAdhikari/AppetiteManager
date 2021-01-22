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
    public partial class SignUp : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
        private const string Letters = "abcdefghijklmnopqrstuvwxyz";
        private readonly char[] Alphanumeric = (Letters + Letters.ToUpper() + "0123456789").ToCharArray();
        public SignUp()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AutoGenCode.Text = GenerateRandomAlphanumeric(Convert.ToInt32(7));
        }

        private string GenerateRandomAlphanumeric(int length)
        {
            StringBuilder result = new StringBuilder();
            Random rn = new Random();
            for (int i = 0; i < length; i++)
            {
                result.Append(Alphanumeric[rn.Next(Alphanumeric.Length)]);
            }
            return result.ToString();

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AddToDB_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO appititemanager1.member(MemberName,PhoneNum,Address,Date,Identification) VALUES('" + MemberName.Text + "','" + MemberPhone.Text + "', '" + MemberAddress.Text + "','" + SubsDate.Value.Date + "','" + AutoGenCode.Text + "')";
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
}

