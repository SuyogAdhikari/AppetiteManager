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
    public partial class GuestOrder : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");

        public GuestOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillingSystem1 BS1 = new BillingSystem1();
            this.Hide();
            BS1.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BillingSystem2 BS2 = new BillingSystem2();
            this.Hide();
            BS2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillingSystem3 BS3 = new BillingSystem3();
            this.Hide();
            BS3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BillingSystem4 BS4 = new BillingSystem4();
            this.Hide();
            BS4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BillingSystem5 BS5 = new BillingSystem5();
            this.Hide();
            BS5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillingSystem6 BS6 = new BillingSystem6();
            this.Hide();
            BS6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BillingSystem7 BS7 = new BillingSystem7();
            this.Hide();
            BS7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BillingSystem8 BS8 = new BillingSystem8();
            this.Hide();
            BS8.Show();
        }
    }
}
