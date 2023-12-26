using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AdminDisplay_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            this.Hide();
        }

        private void WaiterDisplay_Click(object sender, EventArgs e)
        {
            LoginWaiter loginWaiter = new LoginWaiter();
            loginWaiter.Show();
            this.Hide();
        }

        private void KitchenDisplay_Click(object sender, EventArgs e)
        {
            LoginKitchen loginKitchen = new LoginKitchen();
            loginKitchen.Show();
            this.Hide();
        }

        private void CashierDisplay_Click(object sender, EventArgs e)
        {
            LoginCashier loginCashier = new LoginCashier();
            loginCashier.Show();
            this.Hide();
        }


    }
}
