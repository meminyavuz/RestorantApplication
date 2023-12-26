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
    public partial class LoginWaiter : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        public LoginWaiter()
        {
            InitializeComponent();
        }

        private void btnWaiterLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From WaiterRegistration where WaiterUsername=@waiterUserName AND WaiterPassword=@waiterPassword";

                SqlParameter temp1 = new SqlParameter("waiterUsername", txtWaiterLoginUserName.Text);
                SqlParameter temp2 = new SqlParameter("waiterPassword", txtWaiterLoginPassword.Text);

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.Add(temp1);
                command.Parameters.Add(temp2);

                DataTable dtWaiter = new DataTable();

                SqlDataAdapter daWaiter = new SqlDataAdapter(command);

                daWaiter.Fill(dtWaiter);

                if (dtWaiter.Rows.Count > 0)
                {
                    OrderScreen orderScreen = new OrderScreen();
                    orderScreen.Show();
                    this.Hide();
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Incorrect Username or Password");
            }        
        }

        private void btnBackMainMenu1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
