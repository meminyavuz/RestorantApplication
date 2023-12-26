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
    public partial class CashierRegistration : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        public CashierRegistration()
        {
            InitializeComponent();
        }

        private void viewDataCashier()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From CashierRegistration", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["ID"].ToString();
                item.SubItems.Add(reader["CashierName"].ToString());
                item.SubItems.Add(reader["CashierSurname"].ToString());
                item.SubItems.Add(reader["CashierUsername"].ToString());
                item.SubItems.Add(reader["CashierPassword"].ToString());

                listCashier.Items.Add(item);
            }
            connection.Close();
        }

        private void ShowCashier_Click(object sender, EventArgs e)
        {
            listCashier.Items.Clear();
            viewDataCashier();
        }
        
        private void btnAddCashier_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CashierRegistration (ID,CashierName,CashierSurname,CashierUsername,CashierPassword) values ('" + txtIdCashier.Text.ToString() + "','" + txtCashierName.Text.ToString() + "','" + txtCashierSurname.Text.ToString() + "','" + txtCashierUsername.Text.ToString() + "','" + txtCashierPassword.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            txtIdCashier.Clear();
            txtCashierName.Clear();
            txtCashierSurname.Clear();
            txtCashierUsername.Clear();
            txtCashierPassword.Clear();
        }

        int id = 0;
        private void btnDeleteCashier_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From CashierRegistration where ID = ( " + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void listCashier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listCashier.SelectedItems[0].SubItems[0].Text);
            txtIdCashier.Text = listCashier.SelectedItems[0].SubItems[0].Text;
            txtCashierName.Text = listCashier.SelectedItems[0].SubItems[1].Text;
            txtCashierSurname.Text = listCashier.SelectedItems[0].SubItems[2].Text;
            txtCashierUsername.Text = listCashier.SelectedItems[0].SubItems[3].Text;
            txtCashierPassword.Text = listCashier.SelectedItems[0].SubItems[4].Text;
        }

        private void btnUpdateCashier_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update CashierRegistration set ID = '" + txtIdCashier.Text.ToString() + "',CashierName='" + txtCashierName.Text.ToString() + "',CashierSurname='" + txtCashierSurname.Text.ToString() + "',CashierUsername='" + txtCashierUsername.Text.ToString() + "',CashierPassword='" + txtCashierPassword.Text.ToString() + "'where ID=" + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            listCashier.Items.Clear();
            viewDataCashier();
        }

        private void btnBackCashier_Click(object sender, EventArgs e)
        {
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
            this.Hide();
        }
    }
}
