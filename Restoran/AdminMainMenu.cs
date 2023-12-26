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
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void WaiterRegistration_Click(object sender, EventArgs e)
        {
            WaiterRegistrationMenu waiterRegistrationMenu = new WaiterRegistrationMenu();
            waiterRegistrationMenu.Show();
            this.Hide();
        }

        private void btnKitchenRegistration_Click(object sender, EventArgs e)
        {
            KitchenRegistration kitchenRegistration = new KitchenRegistration();
            kitchenRegistration.Show();
            this.Hide();
        }

        private void btnCashierRegistration_Click(object sender, EventArgs e)
        {
            CashierRegistration cashierRegistration = new CashierRegistration();
            cashierRegistration.Show();
            this.Hide();
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnSalesDisplay_Click(object sender, EventArgs e)
        {
            SalesDisplay salesDisplay = new SalesDisplay();
            salesDisplay.Show();
            this.Hide();
        }
    }
}
