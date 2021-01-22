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
    public partial class Menu : UserControl
    {
        MySqlConnection AddConnection = new MySqlConnection("datasource=localhost; username=root;password=");
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(String name, String description, String path, String price)
        {
            InitializeComponent();
            name1.Text = name;
            label6.Text = description;
            button1.Text = price;
            if (System.IO.File.Exists(path))
            {
                Bitmap bitmap = new Bitmap(path);
                FoodImage.ImageLocation = path;
            }
        }



            public String getText()
            {
            return name1.Text;
            }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "1")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table1(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "2")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table2(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "3")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table3(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "4")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table4(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "5")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table5(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "6")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table6(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "7")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table7(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }

                if (comboBox1.SelectedItem.ToString() == "8")
                {
                    decimal ForButton = Convert.ToDecimal(button1.Text);

                    string insertQuery = "INSERT INTO appititemanager1.table8(OrderName,price) VALUES('" + name1.Text + "','" + ForButton + "')";
                    AddConnection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, AddConnection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added to database");
                    }

                    else
                    {
                        MessageBox.Show("failed");
                    }
                    AddConnection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select Table First");
            }
        }
        

        
    }
}
