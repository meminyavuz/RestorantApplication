using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restoran
{
    public partial class WaiterRegistrationMenu : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        private void viewDataWaiter()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From WaiterRegistration", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["ID"].ToString();
                item.SubItems.Add(reader["WaiterName"].ToString());
                item.SubItems.Add(reader["WaiterSurname"].ToString());
                item.SubItems.Add(reader["WaiterUsername"].ToString());
                item.SubItems.Add(reader["WaiterPassword"].ToString());
                
                listWaiter.Items.Add(item);
            }
            connection.Close();
        }
        public WaiterRegistrationMenu()
        {
            InitializeComponent();
        }

        private void ShowWaiters_Click(object sender, EventArgs e)
        {
            listWaiter.Items.Clear();
            viewDataWaiter();
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into WaiterRegistration (ID,WaiterName,WaiterSurname,WaiterUsername,WaiterPassword) values ('"+txtIdWaiter.Text.ToString() +"','"+txtWaiterName.Text.ToString() + "','" + txtWaiterSurname.Text.ToString() +"','"+ txtWaiterUsername.Text.ToString() + "','" + txtWaiterPassword.Text.ToString()+"')",connection);
            command.ExecuteNonQuery();
            connection.Close();
            txtIdWaiter.Clear();
            txtWaiterName.Clear();
            txtWaiterSurname.Clear();
            txtWaiterUsername.Clear();
            txtWaiterPassword.Clear();
        }

        int id = 0;

        private void btnDeleteWaiter_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From WaiterRegistration where ID = ( " + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
            viewDataWaiter();
        }

        private void listWaiter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listWaiter.SelectedItems[0].SubItems[0].Text);
            txtIdWaiter.Text = listWaiter.SelectedItems[0].SubItems[0].Text;
            txtWaiterName.Text=listWaiter.SelectedItems[0].SubItems[1].Text;
            txtWaiterSurname.Text = listWaiter.SelectedItems[0].SubItems[2].Text;
            txtWaiterUsername.Text = listWaiter.SelectedItems[0].SubItems[3].Text;
            txtWaiterPassword.Text = listWaiter.SelectedItems[0].SubItems[4].Text;
        }

        private void btnUpdateWaiter_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update WaiterRegistration set ID = '" + txtIdWaiter.Text.ToString() + "',WaiterName='" + txtWaiterName.Text.ToString() + "',WaiterSurname='" + txtWaiterSurname.Text.ToString() + "',WaiterUsername='" + txtWaiterUsername.Text.ToString() + "',WaiterPassword='" + txtWaiterPassword.Text.ToString() + "'where ID=" + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            listWaiter.Items.Clear();
            listWaiter.Items.Clear();
            viewDataWaiter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
            this.Hide();
        }

        
    }
}
