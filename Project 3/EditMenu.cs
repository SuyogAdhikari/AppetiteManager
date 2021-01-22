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
    public partial class EditMenu : Form
    {
        public EditMenu()
        {
            InitializeComponent();
        }

        private void EditSpecial_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard DB = new DashBoard();
            SpecialEdit SE = new SpecialEdit();
            TitleBar TB = new TitleBar();
            DB.HomeScreen.Controls.Clear();
            DB.HomeScreen.Controls.Add(TB);
            DB.HomeScreen.Controls.Add(SE);
            DB.Show();
        }

        private void GotoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard DB = new DashBoard();
            DB.Show();
            
        }

        private void EditMenus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit E = new Edit();
            E.Show();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRemove AR = new AddRemove();
            AR.Show();
        }
    }
}
