using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appitite_Manager_9
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search")
            {
                Search.Text = "";
                Search.ForeColor = Color.Black;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Search";
                Search.ForeColor = Color.DimGray;
            }

        }
    }
}
