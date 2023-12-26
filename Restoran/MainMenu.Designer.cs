using System.Windows.Forms.VisualStyles;

namespace Restoran
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.CashierDisplay = new System.Windows.Forms.Button();
            this.WaiterDisplay = new System.Windows.Forms.Button();
            this.KitchenDisplay = new System.Windows.Forms.Button();
            this.AdminDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CashierDisplay
            // 
            this.CashierDisplay.BackColor = System.Drawing.Color.Gold;
            this.CashierDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CashierDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CashierDisplay.Location = new System.Drawing.Point(397, 408);
            this.CashierDisplay.Name = "CashierDisplay";
            this.CashierDisplay.Size = new System.Drawing.Size(232, 169);
            this.CashierDisplay.TabIndex = 0;
            this.CashierDisplay.Text = "Cashier Display";
            this.CashierDisplay.UseVisualStyleBackColor = false;
            this.CashierDisplay.Click += new System.EventHandler(this.CashierDisplay_Click);
            // 
            // WaiterDisplay
            // 
            this.WaiterDisplay.BackColor = System.Drawing.Color.Gold;
            this.WaiterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WaiterDisplay.Location = new System.Drawing.Point(159, 408);
            this.WaiterDisplay.Name = "WaiterDisplay";
            this.WaiterDisplay.Size = new System.Drawing.Size(232, 169);
            this.WaiterDisplay.TabIndex = 1;
            this.WaiterDisplay.Text = "Waiter Display";
            this.WaiterDisplay.UseVisualStyleBackColor = false;
            this.WaiterDisplay.Click += new System.EventHandler(this.WaiterDisplay_Click);
            // 
            // KitchenDisplay
            // 
            this.KitchenDisplay.BackColor = System.Drawing.Color.Gold;
            this.KitchenDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitchenDisplay.Location = new System.Drawing.Point(397, 233);
            this.KitchenDisplay.Name = "KitchenDisplay";
            this.KitchenDisplay.Size = new System.Drawing.Size(232, 169);
            this.KitchenDisplay.TabIndex = 2;
            this.KitchenDisplay.Text = "Kitchen Display";
            this.KitchenDisplay.UseVisualStyleBackColor = false;
            this.KitchenDisplay.Click += new System.EventHandler(this.KitchenDisplay_Click);
            // 
            // AdminDisplay
            // 
            this.AdminDisplay.BackColor = System.Drawing.Color.Gold;
            this.AdminDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminDisplay.Location = new System.Drawing.Point(159, 233);
            this.AdminDisplay.Name = "AdminDisplay";
            this.AdminDisplay.Size = new System.Drawing.Size(232, 169);
            this.AdminDisplay.TabIndex = 3;
            this.AdminDisplay.Text = "Admin Display";
            this.AdminDisplay.UseVisualStyleBackColor = false;
            this.AdminDisplay.Click += new System.EventHandler(this.AdminDisplay_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 589);
            this.Controls.Add(this.AdminDisplay);
            this.Controls.Add(this.KitchenDisplay);
            this.Controls.Add(this.WaiterDisplay);
            this.Controls.Add(this.CashierDisplay);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }            
        #endregion

        private System.Windows.Forms.Button CashierDisplay;
        private System.Windows.Forms.Button WaiterDisplay;
        private System.Windows.Forms.Button KitchenDisplay;
        private System.Windows.Forms.Button AdminDisplay;
        
    }
}

