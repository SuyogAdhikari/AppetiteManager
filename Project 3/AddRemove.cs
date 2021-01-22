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
    public partial class AddRemove : Form
    {
        public AddRemove()
        {
            InitializeComponent();
            Add InitializeAdd = new Add();
            ItemDefPanel.Controls.Add(InitializeAdd);
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add A = new Add();
            ItemDefPanel.Controls.Clear();
            ItemDefPanel.Controls.Add(A);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            FoodName R = new FoodName();
            ItemDefPanel.Controls.Clear();
            ItemDefPanel.Controls.Add(R);
        }

      

        private void AddItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EditMenus_Click(object sender, EventArgs e)
        {
            DashBoard DB = new DashBoard();
            DB.HomeScreen.Controls.Clear();
            Edit E = new Edit();
        }

        private void GotoHome_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard DB= new DashBoard();
            DB.Show();
        }
    }
}
