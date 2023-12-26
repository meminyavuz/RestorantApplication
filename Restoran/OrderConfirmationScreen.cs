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
    public partial class OrderConfirmationScreen : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public OrderConfirmationScreen()
        {
            InitializeComponent();
        }
        private void viewDataOrder()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Adisyon", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["ID"].ToString();
                item.SubItems.Add(reader["TableNo"].ToString());
                item.SubItems.Add(reader["MenuNo"].ToString());
                item.SubItems.Add(reader["MenuName"].ToString());
                item.SubItems.Add(reader["Price"].ToString());

                listOrder.Items.Add(item);
            }
            connection.Close();
        }
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            listOrder.Items.Clear();
            viewDataOrder();
        }
        int id = 0;
        private void listOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listOrder.SelectedItems[0].SubItems[0].Text);
            txtIdOrder.Text = listOrder.SelectedItems[0].SubItems[0].Text;
            txtTableNo.Text = listOrder.SelectedItems[0].SubItems[1].Text;
            txtMenuNo.Text = listOrder.SelectedItems[0].SubItems[2].Text;
            txtMenuName.Text = listOrder.SelectedItems[0].SubItems[3].Text;
            txtMenuPrice.Text = listOrder.SelectedItems[0].SubItems[4].Text;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Odeme (IDOdeme,TableNoOdeme,MenuNameOdeme,PriceOdeme) values ('"+ txtIdOrder.Text.ToString() + "','" + txtTableNo.Text.ToString() + "','" + txtMenuName.Text.ToString() + "','" + txtMenuPrice.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            SqlCommand commandDelete = new SqlCommand("Delete From Adisyon where ID = ( " + id + ")", connection);
            commandDelete.ExecuteNonQuery();
            connection.Close();
            txtIdOrder.Clear();
            txtTableNo.Clear();
            txtMenuNo.Clear();
            txtMenuName.Clear();
            txtMenuPrice.Clear();
        }

        private void btnBackKitchen_Click(object sender, EventArgs e)
        {
            LoginKitchen loginKitchen = new LoginKitchen();
            loginKitchen.Show();
            this.Hide();

        }
    }
}
