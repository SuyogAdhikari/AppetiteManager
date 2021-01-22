using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appitite_Manager_9.Properties;

namespace Appitite_Manager_9
{
    public partial class MenuBar : UserControl
    {
        bool isCollapsedMenu;
        bool isCollapsedCustomer;
        public MenuBar()
        {
            InitializeComponent();
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

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerTimer.Start();
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
