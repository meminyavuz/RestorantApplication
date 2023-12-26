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
    public partial class CashierScreen : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public CashierScreen()
        {
            InitializeComponent();
        }
        private void viewDataPayment()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Odeme", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["IDOdeme"].ToString();
                item.SubItems.Add(reader["TableNoOdeme"].ToString());
                item.SubItems.Add(reader["MenuNameOdeme"].ToString());
                item.SubItems.Add(reader["PriceOdeme"].ToString());

                listPayment.Items.Add(item);
            }
            connection.Close();
        }


        private void btnShowPayment_Click(object sender, EventArgs e)
        {
            listPayment.Items.Clear();
            viewDataPayment();
        }

        int id = 0;
        private void listPayment_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listPayment.SelectedItems[0].SubItems[0].Text);
            txtIdCashier.Text = listPayment.SelectedItems[0].SubItems[0].Text;
            txtCashierTableNo.Text = listPayment.SelectedItems[0].SubItems[1].Text;
            txtCashierMenuName.Text = listPayment.SelectedItems[0].SubItems[2].Text;
            txtCashierMenuPrice.Text = listPayment.SelectedItems[0].SubItems[3].Text;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            connection.Open();           
            SqlCommand command = new SqlCommand("insert into ShowSales (IDShow,TableNoShow,MenuNameShow,MenuPriceShow) values ('"+ txtIdCashier.Text.ToString() + "','" + txtCashierTableNo.Text.ToString() + "','" + txtCashierMenuName.Text.ToString() + "','" + txtCashierMenuPrice.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            SqlCommand commandDelete = new SqlCommand("Delete From Odeme where IDOdeme = ( " + id + ")", connection);
            commandDelete.ExecuteNonQuery();
            connection.Close();
            txtIdCashier.Clear();
            txtCashierTableNo.Clear();
            txtCashierMenuName.Clear();
            txtCashierMenuPrice.Clear();
        }

        private void btnBackCashier_Click(object sender, EventArgs e)
        {
            LoginCashier loginCashier = new LoginCashier();
            loginCashier.Show();
            this.Hide();
        }
    }
}
