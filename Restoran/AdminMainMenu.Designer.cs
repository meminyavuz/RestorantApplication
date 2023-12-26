namespace Restoran
{
    partial class AdminMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainMenu));
            this.WaiterRegistration = new System.Windows.Forms.Button();
            this.btnKitchenRegistration = new System.Windows.Forms.Button();
            this.btnSalesDisplay = new System.Windows.Forms.Button();
            this.btnCashierRegistration = new System.Windows.Forms.Button();
            this.btnBackAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WaiterRegistration
            // 
            this.WaiterRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WaiterRegistration.Location = new System.Drawing.Point(191, 245);
            this.WaiterRegistration.Name = "WaiterRegistration";
            this.WaiterRegistration.Size = new System.Drawing.Size(138, 129);
            this.WaiterRegistration.TabIndex = 1;
            this.WaiterRegistration.Text = "Waiter Registration";
            this.WaiterRegistration.UseVisualStyleBackColor = true;
            this.WaiterRegistration.Click += new System.EventHandler(this.WaiterRegistration_Click);
            // 
            // btnKitchenRegistration
            // 
            this.btnKitchenRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitchenRegistration.Location = new System.Drawing.Point(335, 245);
            this.btnKitchenRegistration.Name = "btnKitchenRegistration";
            this.btnKitchenRegistration.Size = new System.Drawing.Size(138, 129);
            this.btnKitchenRegistration.TabIndex = 2;
            this.btnKitchenRegistration.Text = "Kitchen Registration";
            this.btnKitchenRegistration.UseVisualStyleBackColor = true;
            this.btnKitchenRegistration.Click += new System.EventHandler(this.btnKitchenRegistration_Click);
            // 
            // btnSalesDisplay
            // 
            this.btnSalesDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalesDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesDisplay.Location = new System.Drawing.Point(191, 396);
            this.btnSalesDisplay.Name = "btnSalesDisplay";
            this.btnSalesDisplay.Size = new System.Drawing.Size(426, 129);
            this.btnSalesDisplay.TabIndex = 3;
            this.btnSalesDisplay.Text = "Sales Display";
            this.btnSalesDisplay.UseVisualStyleBackColor = false;
            this.btnSalesDisplay.Click += new System.EventHandler(this.btnSalesDisplay_Click);
            // 
            // btnCashierRegistration
            // 
            this.btnCashierRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCashierRegistration.Location = new System.Drawing.Point(479, 245);
            this.btnCashierRegistration.Name = "btnCashierRegistration";
            this.btnCashierRegistration.Size = new System.Drawing.Size(138, 129);
            this.btnCashierRegistration.TabIndex = 4;
            this.btnCashierRegistration.Text = "Cashier Registration";
            this.btnCashierRegistration.UseVisualStyleBackColor = true;
            this.btnCashierRegistration.Click += new System.EventHandler(this.btnCashierRegistration_Click);
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(56, 44);
            this.btnBackAdmin.TabIndex = 47;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 573);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.btnCashierRegistration);
            this.Controls.Add(this.btnSalesDisplay);
            this.Controls.Add(this.btnKitchenRegistration);
            this.Controls.Add(this.WaiterRegistration);
            this.DoubleBuffered = true;
            this.Name = "AdminMainMenu";
            this.Text = "AdminMainMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button WaiterRegistration;
        private System.Windows.Forms.Button btnKitchenRegistration;
        private System.Windows.Forms.Button btnSalesDisplay;
        private System.Windows.Forms.Button btnCashierRegistration;
        private System.Windows.Forms.Button btnBackAdmin;
    }
}