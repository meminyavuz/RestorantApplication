using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class SalesDisplay : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public SalesDisplay()
        {
            InitializeComponent();
        }
        private void viewDataShowSales()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From ShowSales", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["IDShow"].ToString();
                item.SubItems.Add(reader["TableNoShow"].ToString());
                item.SubItems.Add(reader["MenuNameShow"].ToString());
                item.SubItems.Add(reader["MenuPriceShow"].ToString());

                listShowSales.Items.Add(item);
            }
            connection.Close();
        }
        private void btnShowSales_Click(object sender, EventArgs e)
        {
            listShowSales.Items.Clear();
            viewDataShowSales();
        }
        private void sumSales()
        {
            connection.Open();
            int sum = 0;
            SqlCommand command = new SqlCommand("Select * From ShowSales where MenuPriceShow", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                
                sum += Convert.ToInt32(item);


            }
        }

        private void btnBackAdmin2_Click(object sender, EventArgs e)
        {
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
            this.Hide();
        }
    }
}
