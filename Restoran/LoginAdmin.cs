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
    public partial class LoginAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2FKN5LJ\\MYSQLSERVER;Initial Catalog=Restorant;Integrated Security=True");
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From Admin where AdminUserName=@adminUserName AND AdminPassword=@adminPassword";

                SqlParameter temp1 = new SqlParameter("adminUserName", txtAdminUserName.Text);
                SqlParameter temp2 = new SqlParameter("adminPassword",txtAdminPassword.Text);

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.Add(temp1);
                command.Parameters.Add(temp2);

                DataTable dtAdmin = new DataTable();

                SqlDataAdapter daAdmin = new SqlDataAdapter(command);

                daAdmin.Fill(dtAdmin);

                if(dtAdmin.Rows.Count > 0)
                {
                    AdminMainMenu adminMainMenu = new AdminMainMenu();
                    adminMainMenu.Show();
                    this.Hide();
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void btnBackMainMenu4_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
