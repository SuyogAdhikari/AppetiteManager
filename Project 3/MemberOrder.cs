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

    public partial class MemberOrder : UserControl
    {
        public struct BillInfo
        {
            public string Food;
            public decimal Price;
        }

        public struct MemberInfo
        {
            
        }

        BillInfo[] BI = new BillInfo[200];

        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        public MemberOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
                int i = 0;
                AddConnection.Open();
                MySqlCommand cmd = AddConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    Failed.Text = "NO Membership Found!!";
                }

                else
                {
                this.Hide();
                BillingSystem1 BS1 = new BillingSystem1();
                BS1.Show();
                }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem2 BS1 = new BillingSystem2();
                BS1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem3 BS1 = new BillingSystem3();
                BS1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem4 BS1 = new BillingSystem4();
                BS1.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem5 BS1 = new BillingSystem5();
                BS1.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem6 BS1 = new BillingSystem6();
                BS1.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem7 BS1 = new BillingSystem7();
                BS1.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = 0;
            AddConnection.Open();
            MySqlCommand cmd = AddConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appititemanager1.member where MembershipID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                Failed.Text = "NO Membership Found!!";
            }

            else
            {
                this.Hide();
                BillingSystem8 BS1 = new BillingSystem8();
                BS1.Show();
            }
        }
    }
}
