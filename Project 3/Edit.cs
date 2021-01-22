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
    public partial class Edit : Form
    {
        AppitizerEdit AE = new AppitizerEdit();
        public Edit()
        {
            InitializeComponent();
            EditFood.Controls.Add(AE);

        }

        private void PowerButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Appitizer_Click_1(object sender, EventArgs e)
        {

            if (!EditFood.Controls.Contains(AE))
            {
                EditFood.Controls.Clear();
                EditFood.Controls.Add(AE);
            }
        }

        private void Soups_Click_1(object sender, EventArgs e)
        {
            SoupEdit SE = new SoupEdit();
            EditFood.Controls.Clear();
            EditFood.Controls.Add(SE);
        }

        private void Salads_Click_1(object sender, EventArgs e)
        {
            SaladEdit SaE = new SaladEdit();
            EditFood.Controls.Clear();
            EditFood.Controls.Add(SaE);
        }

        private void Dessert_Click_1(object sender, EventArgs e)
        {

            DessertEdit DE = new DessertEdit();
            EditFood.Controls.Clear();
            EditFood.Controls.Add(DE);
        }

        private void GotoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dd = new DashBoard();
            dd.Show();
        }
    }
}
