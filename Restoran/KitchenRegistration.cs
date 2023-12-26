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
    public partial class KitchenRegistration : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public KitchenRegistration()
        {
            InitializeComponent();
        }
        private void viewDataKitchen()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From KitchenRegistration", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["ID"].ToString();
                item.SubItems.Add(reader["KitchenName"].ToString());
                item.SubItems.Add(reader["KitchenSurname"].ToString());
                item.SubItems.Add(reader["KitchenUsername"].ToString());
                item.SubItems.Add(reader["KitchenPassword"].ToString());

                listKitchen.Items.Add(item);
            }
            connection.Close();
        }

        private void ShowKitchens_Click(object sender, EventArgs e)
        {
            listKitchen.Items.Clear();
            viewDataKitchen();
        }

        private void btnAddKitchen_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into KitchenRegistration (ID,KitchenName,KitchenSurname,KitchenUsername,KitchenPassword) values ('"+txtIdKitchen.Text.ToString() + " ',' "+txtKitchenName.Text.ToString() + " ',' " + txtKitchenSurname.Text.ToString() + "','"+txtKitchenUsername.Text.ToString() + "','" + txtKitchenPassword.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            txtIdKitchen.Clear();
            txtKitchenName.Clear();
            txtKitchenSurname.Clear();
            txtKitchenUsername.Clear();
            txtKitchenPassword.Clear();
        }

        int id = 0;
        private void btnDeleteKitchen_Click(object sender, EventArgs e)
        {   
        connection.Open();
        SqlCommand command = new SqlCommand("Delete From KitchenRegistration where ID = ( " + id + ")", connection);
        command.ExecuteNonQuery();
        connection.Close();
        }

        private void listKitchen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listKitchen.SelectedItems[0].SubItems[0].Text);
            txtIdKitchen.Text = listKitchen.SelectedItems[0].SubItems[0].Text;
            txtKitchenName.Text = listKitchen.SelectedItems[0].SubItems[1].Text;
            txtKitchenSurname.Text = listKitchen.SelectedItems[0].SubItems[2].Text;
            txtKitchenUsername.Text = listKitchen.SelectedItems[0].SubItems[3].Text;
            txtKitchenPassword.Text = listKitchen.SelectedItems[0].SubItems[4].Text;
        }

        private void btnUpdateKitchen_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update KitchenRegistration set ID = '" + txtIdKitchen.Text.ToString() + "',KitchenName='" + txtKitchenName.Text.ToString() + "',KitchenSurname='" + txtKitchenSurname.Text.ToString() + "',KitchenUsername='" + txtKitchenUsername.Text.ToString() + "',KitchenPassword='" + txtKitchenPassword.Text.ToString() + "'where ID=" + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            listKitchen.Items.Clear();
            viewDataKitchen();
        }

        private void btnBackKitchen_Click(object sender, EventArgs e)
        {
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
            this.Hide();
        }

       
    }
}
