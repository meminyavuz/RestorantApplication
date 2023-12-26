namespace Restoran
{
    partial class SalesDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDisplay));
            this.listShowSales = new System.Windows.Forms.ListView();
            this.IDCashier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierTableNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierMenuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierMenuPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowSales = new System.Windows.Forms.Button();
            this.btnBackAdmin2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listShowSales
            // 
            this.listShowSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCashier,
            this.CashierTableNo,
            this.CashierMenuName,
            this.CashierMenuPrice});
            this.listShowSales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listShowSales.HideSelection = false;
            this.listShowSales.Location = new System.Drawing.Point(58, 147);
            this.listShowSales.Name = "listShowSales";
            this.listShowSales.Size = new System.Drawing.Size(623, 205);
            this.listShowSales.TabIndex = 38;
            this.listShowSales.UseCompatibleStateImageBehavior = false;
            this.listShowSales.View = System.Windows.Forms.View.Details;
            // 
            // IDCashier
            // 
            this.IDCashier.Text = "ID";
            this.IDCashier.Width = 37;
            // 
            // CashierTableNo
            // 
            this.CashierTableNo.Text = "TableNo";
            this.CashierTableNo.Width = 57;
            // 
            // CashierMenuName
            // 
            this.CashierMenuName.Text = "MenuName";
            this.CashierMenuName.Width = 145;
            // 
            // CashierMenuPrice
            // 
            this.CashierMenuPrice.Text = "Menu Price";
            this.CashierMenuPrice.Width = 111;
            // 
            // btnShowSales
            // 
            this.btnShowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowSales.Location = new System.Drawing.Point(58, 94);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(623, 47);
            this.btnShowSales.TabIndex = 39;
            this.btnShowSales.Text = "Show Sales";
            this.btnShowSales.UseVisualStyleBackColor = true;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // btnBackAdmin2
            // 
            this.btnBackAdmin2.Location = new System.Drawing.Point(12, 12);
            this.btnBackAdmin2.Name = "btnBackAdmin2";
            this.btnBackAdmin2.Size = new System.Drawing.Size(56, 44);
            this.btnBackAdmin2.TabIndex = 48;
            this.btnBackAdmin2.Text = "Back";
            this.btnBackAdmin2.UseVisualStyleBackColor = true;
            this.btnBackAdmin2.Click += new System.EventHandler(this.btnBackAdmin2_Click);
            // 
            // SalesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.btnBackAdmin2);
            this.Controls.Add(this.btnShowSales);
            this.Controls.Add(this.listShowSales);
            this.DoubleBuffered = true;
            this.Name = "SalesDisplay";
            this.Text = "SalesDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listShowSales;
        private System.Windows.Forms.ColumnHeader IDCashier;
        private System.Windows.Forms.ColumnHeader CashierTableNo;
        private System.Windows.Forms.ColumnHeader CashierMenuName;
        private System.Windows.Forms.ColumnHeader CashierMenuPrice;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.Button btnBackAdmin2;
    }
}