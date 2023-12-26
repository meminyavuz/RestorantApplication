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
    public partial class OrderScreen : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        public OrderScreen()
        {
            InitializeComponent();
        }

        private void viewDataMenu()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Menu", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["ID"].ToString();
                item.SubItems.Add(reader["MenuIsim"].ToString());
                item.SubItems.Add(reader["MenuFiyat"].ToString());

                listMenu.Items.Add(item);
            }
            connection.Close();
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            listMenu.Items.Clear();
            viewDataMenu(); 
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
        private void listMenuView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listMenu.SelectedItems[0].SubItems[0].Text);
            txtMenuNo.Text = listMenu.SelectedItems[0].SubItems[0].Text;
            txtMenuName.Text = listMenu.SelectedItems[0].SubItems[1].Text;
            txtMenuPrice.Text = listMenu.SelectedItems[0].SubItems[2].Text;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Adisyon (ID,TableNo,MenuNo,MenuName,Price) values ('" + txtIdOrder.Text.ToString() + "','" + txtTableNo.Text.ToString() + "','" + txtMenuNo.Text.ToString() + "','" + txtMenuName.Text.ToString() + "','" + txtMenuPrice.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            txtIdOrder.Clear();
            txtTableNo.Clear();
            txtMenuNo.Clear();
            txtMenuName.Clear();
            txtMenuPrice.Clear();
            
        }

        private void btnBackWaiter_Click(object sender, EventArgs e)
        {
            LoginWaiter loginWaiter = new LoginWaiter();
            loginWaiter.Show();
            this.Hide();
        }
    }
}
