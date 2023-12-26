namespace Restoran
{
    partial class CashierScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierScreen));
            this.txtIdCashier = new System.Windows.Forms.TextBox();
            this.lblIdCashier = new System.Windows.Forms.Label();
            this.txtCashierMenuPrice = new System.Windows.Forms.TextBox();
            this.txtCashierMenuName = new System.Windows.Forms.TextBox();
            this.txtCashierTableNo = new System.Windows.Forms.TextBox();
            this.lblCashierMenuPrice = new System.Windows.Forms.Label();
            this.lblCashierMenuName = new System.Windows.Forms.Label();
            this.lblCashierTableNo = new System.Windows.Forms.Label();
            this.listPayment = new System.Windows.Forms.ListView();
            this.IDCashier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierTableNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierMenuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierMenuPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnShowPayment = new System.Windows.Forms.Button();
            this.btnBackCashier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdCashier
            // 
            this.txtIdCashier.Location = new System.Drawing.Point(51, 168);
            this.txtIdCashier.Name = "txtIdCashier";
            this.txtIdCashier.ReadOnly = true;
            this.txtIdCashier.Size = new System.Drawing.Size(46, 20);
            this.txtIdCashier.TabIndex = 36;
            // 
            // lblIdCashier
            // 
            this.lblIdCashier.AutoSize = true;
            this.lblIdCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdCashier.Location = new System.Drawing.Point(12, 168);
            this.lblIdCashier.Name = "lblIdCashier";
            this.lblIdCashier.Size = new System.Drawing.Size(33, 20);
            this.lblIdCashier.TabIndex = 35;
            this.lblIdCashier.Text = "ID:";
            // 
            // txtCashierMenuPrice
            // 
            this.txtCashierMenuPrice.Location = new System.Drawing.Point(103, 295);
            this.txtCashierMenuPrice.Name = "txtCashierMenuPrice";
            this.txtCashierMenuPrice.ReadOnly = true;
            this.txtCashierMenuPrice.Size = new System.Drawing.Size(65, 20);
            this.txtCashierMenuPrice.TabIndex = 34;
            // 
            // txtCashierMenuName
            // 
            this.txtCashierMenuName.Location = new System.Drawing.Point(103, 247);
            this.txtCashierMenuName.Name = "txtCashierMenuName";
            this.txtCashierMenuName.ReadOnly = true;
            this.txtCashierMenuName.Size = new System.Drawing.Size(92, 20);
            this.txtCashierMenuName.TabIndex = 33;
            // 
            // txtCashierTableNo
            // 
            this.txtCashierTableNo.Location = new System.Drawing.Point(103, 206);
            this.txtCashierTableNo.Name = "txtCashierTableNo";
            this.txtCashierTableNo.ReadOnly = true;
            this.txtCashierTableNo.Size = new System.Drawing.Size(65, 20);
            this.txtCashierTableNo.TabIndex = 31;
            // 
            // lblCashierMenuPrice
            // 
            this.lblCashierMenuPrice.AutoSize = true;
            this.lblCashierMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierMenuPrice.Location = new System.Drawing.Point(12, 295);
            this.lblCashierMenuPrice.Name = "lblCashierMenuPrice";
            this.lblCashierMenuPrice.Size = new System.Drawing.Size(54, 20);
            this.lblCashierMenuPrice.TabIndex = 30;
            this.lblCashierMenuPrice.Text = "Price:";
            // 
            // lblCashierMenuName
            // 
            this.lblCashierMenuName.AutoSize = true;
            this.lblCashierMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierMenuName.Location = new System.Drawing.Point(12, 247);
            this.lblCashierMenuName.Name = "lblCashierMenuName";
            this.lblCashierMenuName.Size = new System.Drawing.Size(60, 20);
            this.lblCashierMenuName.TabIndex = 29;
            this.lblCashierMenuName.Text = "Name:";
            // 
            // lblCashierTableNo
            // 
            this.lblCashierTableNo.AutoSize = true;
            this.lblCashierTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierTableNo.Location = new System.Drawing.Point(12, 206);
            this.lblCashierTableNo.Name = "lblCashierTableNo";
            this.lblCashierTableNo.Size = new System.Drawing.Size(85, 20);
            this.lblCashierTableNo.TabIndex = 27;
            this.lblCashierTableNo.Text = "Table No:";
            // 
            // listPayment
            // 
            this.listPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCashier,
            this.CashierTableNo,
            this.CashierMenuName,
            this.CashierMenuPrice});
            this.listPayment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPayment.HideSelection = false;
            this.listPayment.Location = new System.Drawing.Point(12, 346);
            this.listPayment.Name = "listPayment";
            this.listPayment.Size = new System.Drawing.Size(623, 165);
            this.listPayment.TabIndex = 37;
            this.listPayment.UseCompatibleStateImageBehavior = false;
            this.listPayment.View = System.Windows.Forms.View.Details;
            this.listPayment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPayment_MouseDoubleClick);
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
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(417, 282);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(106, 58);
            this.btnPayment.TabIndex = 39;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnShowPayment
            // 
            this.btnShowPayment.Location = new System.Drawing.Point(529, 282);
            this.btnShowPayment.Name = "btnShowPayment";
            this.btnShowPayment.Size = new System.Drawing.Size(106, 58);
            this.btnShowPayment.TabIndex = 38;
            this.btnShowPayment.Text = "Show Payment";
            this.btnShowPayment.UseVisualStyleBackColor = true;
            this.btnShowPayment.Click += new System.EventHandler(this.btnShowPayment_Click);
            // 
            // btnBackCashier
            // 
            this.btnBackCashier.Location = new System.Drawing.Point(12, 12);
            this.btnBackCashier.Name = "btnBackCashier";
            this.btnBackCashier.Size = new System.Drawing.Size(56, 44);
            this.btnBackCashier.TabIndex = 48;
            this.btnBackCashier.Text = "Back";
            this.btnBackCashier.UseVisualStyleBackColor = true;
            this.btnBackCashier.Click += new System.EventHandler(this.btnBackCashier_Click);
            // 
            // CashierScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 614);
            this.Controls.Add(this.btnBackCashier);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnShowPayment);
            this.Controls.Add(this.listPayment);
            this.Controls.Add(this.txtIdCashier);
            this.Controls.Add(this.lblIdCashier);
            this.Controls.Add(this.txtCashierMenuPrice);
            this.Controls.Add(this.txtCashierMenuName);
            this.Controls.Add(this.txtCashierTableNo);
            this.Controls.Add(this.lblCashierMenuPrice);
            this.Controls.Add(this.lblCashierMenuName);
            this.Controls.Add(this.lblCashierTableNo);
            this.DoubleBuffered = true;
            this.Name = "CashierScreen";
            this.Text = "CashierScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCashier;
        private System.Windows.Forms.Label lblIdCashier;
        private System.Windows.Forms.TextBox txtCashierMenuPrice;
        private System.Windows.Forms.TextBox txtCashierMenuName;
        private System.Windows.Forms.TextBox txtCashierTableNo;
        private System.Windows.Forms.Label lblCashierMenuPrice;
        private System.Windows.Forms.Label lblCashierMenuName;
        private System.Windows.Forms.Label lblCashierTableNo;
        private System.Windows.Forms.ListView listPayment;
        private System.Windows.Forms.ColumnHeader IDCashier;
        private System.Windows.Forms.ColumnHeader CashierTableNo;
        private System.Windows.Forms.ColumnHeader CashierMenuName;
        private System.Windows.Forms.ColumnHeader CashierMenuPrice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnShowPayment;
        private System.Windows.Forms.Button btnBackCashier;
    }
}