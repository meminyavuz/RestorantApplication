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
    public partial class LoginCashier : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        public LoginCashier()
        {
            InitializeComponent();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From CashierRegistration where CashierUsername=@cashierUserName AND CashierPassword=@cashierPassword";

                SqlParameter temp1 = new SqlParameter("cashierUsername", txtCashierLoginUserName.Text);
                SqlParameter temp2 = new SqlParameter("cashierPassword", txtCashierLoginPassword.Text);

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.Add(temp1);
                command.Parameters.Add(temp2);

                DataTable dtCashier = new DataTable();

                SqlDataAdapter daCashier = new SqlDataAdapter(command);

                daCashier.Fill(dtCashier);

                if (dtCashier.Rows.Count > 0)
                {

                    CashierScreen cashierScreen = new CashierScreen();
                    cashierScreen.Show();
                    this.Hide();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void btnBackMainMenu3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
    
}
