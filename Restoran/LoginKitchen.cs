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
    public partial class LoginKitchen : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        public LoginKitchen()
        {
            InitializeComponent();
        }

        private void btnKitchenLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From KitchenRegistration where KitchenUsername=@kitchenUserName AND KitchenPassword=@kitchenPassword";

                SqlParameter temp1 = new SqlParameter("kitchenUsername", txtKitchenLoginUserName.Text);
                SqlParameter temp2 = new SqlParameter("kitchenPassword", txtKitchenLoginPassword.Text);

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.Add(temp1);
                command.Parameters.Add(temp2);

                DataTable dtKitchen = new DataTable();

                SqlDataAdapter daKitchen = new SqlDataAdapter(command);

                daKitchen.Fill(dtKitchen);

                if (dtKitchen.Rows.Count > 0)
                {

                    OrderConfirmationScreen orderConfirmationScreen = new OrderConfirmationScreen();
                    orderConfirmationScreen.Show();
                    this.Hide();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void btnBackMainMenu2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
    
}
