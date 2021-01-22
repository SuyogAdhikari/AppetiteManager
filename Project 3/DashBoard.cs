using Appitite_Manager_9.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appitite_Manager_9
{

    public partial class DashBoard : Form
    {
        bool isCollapsedMenu;
        bool isCollapsedCustomer;

        public DashBoard()
        {
           InitializeComponent();           
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {

            if (isCollapsedMenu)
            {
                Menu.Image = Resources.up;
                MenuPanel.Height += 10;
                if (MenuPanel.Size == MenuPanel.MaximumSize)
                {
                    MenuTimer.Stop();
                    isCollapsedMenu = false;
                }
            }

            else
            {
                Menu.Image = Resources.down;
                MenuPanel.Height -= 10;
                if (MenuPanel.Size == MenuPanel.MinimumSize)
                {
                    MenuTimer.Stop();
                    isCollapsedMenu = true;
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void CustomerTimer_Tick(object sender, EventArgs e)
        {

            if (isCollapsedCustomer)
            {
                Customer.Image = Resources.up;
                CustomerPanel.Height += 10;
                if (CustomerPanel.Size == CustomerPanel.MaximumSize)
                {
                    CustomerTimer.Stop();
                    isCollapsedCustomer = false;
                }
            }

            else
            {
                Customer.Image = Resources.down;
                CustomerPanel.Height -= 10;
                if (CustomerPanel.Size == CustomerPanel.MinimumSize)
                {
                    CustomerTimer.Stop();
                    isCollapsedCustomer = true;
                }
            }
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerTimer.Start();
        }

        private void Collection_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthenticateCollection AU = new AuthenticateCollection();
            AU.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            HomeScreen.Controls.Add(titleBar1);
            HomeScreen.Controls.Add(menuDashBoard1);
           
        }

        private void Appitizer_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            Appitizer A = new Appitizer();
            HomeScreen.Controls.Add(A);
           
        }

        private void Soups_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            Soup S = new Soup();
            HomeScreen.Controls.Add(S);
          
        }

        private void Salads_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            Salad SE = new Salad();
            HomeScreen.Controls.Add(SE);
            //Salad SaE = new Salad();

        }

        private void Dessert_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            Dessert D = new Dessert();
            HomeScreen.Controls.Add(D);
       
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            AuthenticateSetting AS = new AuthenticateSetting();
            AS.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            SignUp SU = new SignUp();
            HomeScreen.Controls.Add(SU);
        }

        private void menuDashBoard1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            MemberOrder MO = new MemberOrder();
            HomeScreen.Controls.Add(MO);
        }

     

        private void button10_Click(object sender, EventArgs e)
        {
            HomeScreen.Controls.Clear();
            GuestOrder GO = new GuestOrder();
            HomeScreen.Controls.Add(GO);
        }
    }
}
