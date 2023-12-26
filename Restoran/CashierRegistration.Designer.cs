namespace Restoran
{
    partial class CashierRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierRegistration));
            this.btnBackCashier = new System.Windows.Forms.Button();
            this.btnUpdateCashier = new System.Windows.Forms.Button();
            this.btnDeleteCashier = new System.Windows.Forms.Button();
            this.btnAddCashier = new System.Windows.Forms.Button();
            this.ShowCashier = new System.Windows.Forms.Button();
            this.lblIdCashier = new System.Windows.Forms.Label();
            this.lblCashierPassword = new System.Windows.Forms.Label();
            this.lblCashierUsername = new System.Windows.Forms.Label();
            this.lblCashierSurname = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.listCashier = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIdCashier = new System.Windows.Forms.TextBox();
            this.txtCashierPassword = new System.Windows.Forms.TextBox();
            this.txtCashierUsername = new System.Windows.Forms.TextBox();
            this.txtCashierSurname = new System.Windows.Forms.TextBox();
            this.txtCashierName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackCashier
            // 
            this.btnBackCashier.Location = new System.Drawing.Point(16, 13);
            this.btnBackCashier.Name = "btnBackCashier";
            this.btnBackCashier.Size = new System.Drawing.Size(56, 44);
            this.btnBackCashier.TabIndex = 46;
            this.btnBackCashier.Text = "Back";
            this.btnBackCashier.UseVisualStyleBackColor = true;
            this.btnBackCashier.Click += new System.EventHandler(this.btnBackCashier_Click);
            // 
            // btnUpdateCashier
            // 
            this.btnUpdateCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCashier.Location = new System.Drawing.Point(490, 229);
            this.btnUpdateCashier.Name = "btnUpdateCashier";
            this.btnUpdateCashier.Size = new System.Drawing.Size(116, 32);
            this.btnUpdateCashier.TabIndex = 45;
            this.btnUpdateCashier.Text = "Update Cashier";
            this.btnUpdateCashier.UseVisualStyleBackColor = true;
            this.btnUpdateCashier.Click += new System.EventHandler(this.btnUpdateCashier_Click);
            // 
            // btnDeleteCashier
            // 
            this.btnDeleteCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCashier.Location = new System.Drawing.Point(612, 153);
            this.btnDeleteCashier.Name = "btnDeleteCashier";
            this.btnDeleteCashier.Size = new System.Drawing.Size(116, 58);
            this.btnDeleteCashier.TabIndex = 44;
            this.btnDeleteCashier.Text = "Delete Cashier";
            this.btnDeleteCashier.UseVisualStyleBackColor = true;
            this.btnDeleteCashier.Click += new System.EventHandler(this.btnDeleteCashier_Click);
            // 
            // btnAddCashier
            // 
            this.btnAddCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCashier.Location = new System.Drawing.Point(612, 89);
            this.btnAddCashier.Name = "btnAddCashier";
            this.btnAddCashier.Size = new System.Drawing.Size(116, 58);
            this.btnAddCashier.TabIndex = 43;
            this.btnAddCashier.Text = "Add Cashier";
            this.btnAddCashier.UseVisualStyleBackColor = true;
            this.btnAddCashier.Click += new System.EventHandler(this.btnAddCashier_Click);
            // 
            // ShowCashier
            // 
            this.ShowCashier.Location = new System.Drawing.Point(612, 229);
            this.ShowCashier.Name = "ShowCashier";
            this.ShowCashier.Size = new System.Drawing.Size(116, 32);
            this.ShowCashier.TabIndex = 42;
            this.ShowCashier.Text = "Show Cashier(s)";
            this.ShowCashier.UseVisualStyleBackColor = true;
            this.ShowCashier.Click += new System.EventHandler(this.ShowCashier_Click);
            // 
            // lblIdCashier
            // 
            this.lblIdCashier.AutoSize = true;
            this.lblIdCashier.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdCashier.ForeColor = System.Drawing.Color.LightCyan;
            this.lblIdCashier.Location = new System.Drawing.Point(121, 117);
            this.lblIdCashier.Name = "lblIdCashier";
            this.lblIdCashier.Size = new System.Drawing.Size(30, 20);
            this.lblIdCashier.TabIndex = 41;
            this.lblIdCashier.Text = "ID:";
            // 
            // lblCashierPassword
            // 
            this.lblCashierPassword.AutoSize = true;
            this.lblCashierPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierPassword.ForeColor = System.Drawing.Color.LightCyan;
            this.lblCashierPassword.Location = new System.Drawing.Point(19, 232);
            this.lblCashierPassword.Name = "lblCashierPassword";
            this.lblCashierPassword.Size = new System.Drawing.Size(140, 20);
            this.lblCashierPassword.TabIndex = 40;
            this.lblCashierPassword.Text = "Cashier Password:";
            // 
            // lblCashierUsername
            // 
            this.lblCashierUsername.AutoSize = true;
            this.lblCashierUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierUsername.ForeColor = System.Drawing.Color.LightCyan;
            this.lblCashierUsername.Location = new System.Drawing.Point(14, 203);
            this.lblCashierUsername.Name = "lblCashierUsername";
            this.lblCashierUsername.Size = new System.Drawing.Size(145, 20);
            this.lblCashierUsername.TabIndex = 39;
            this.lblCashierUsername.Text = "Cashier Username:";
            // 
            // lblCashierSurname
            // 
            this.lblCashierSurname.AutoSize = true;
            this.lblCashierSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierSurname.ForeColor = System.Drawing.Color.LightCyan;
            this.lblCashierSurname.Location = new System.Drawing.Point(23, 172);
            this.lblCashierSurname.Name = "lblCashierSurname";
            this.lblCashierSurname.Size = new System.Drawing.Size(136, 20);
            this.lblCashierSurname.TabIndex = 38;
            this.lblCashierSurname.Text = "Cashier Surname:";
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblCashierName.Location = new System.Drawing.Point(46, 143);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(113, 20);
            this.lblCashierName.TabIndex = 37;
            this.lblCashierName.Text = "Cashier Name:";
            // 
            // listCashier
            // 
            this.listCashier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CashierName,
            this.CashierSurname,
            this.CashierUsername,
            this.CashierPassword});
            this.listCashier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listCashier.HideSelection = false;
            this.listCashier.Location = new System.Drawing.Point(16, 272);
            this.listCashier.Name = "listCashier";
            this.listCashier.Size = new System.Drawing.Size(712, 165);
            this.listCashier.TabIndex = 36;
            this.listCashier.UseCompatibleStateImageBehavior = false;
            this.listCashier.View = System.Windows.Forms.View.Details;
            this.listCashier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCashier_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 38;
            // 
            // CashierName
            // 
            this.CashierName.Text = "Cashier Name";
            this.CashierName.Width = 164;
            // 
            // CashierSurname
            // 
            this.CashierSurname.Text = "Cashier Surname";
            this.CashierSurname.Width = 175;
            // 
            // CashierUsername
            // 
            this.CashierUsername.Text = "Cashier Username";
            this.CashierUsername.Width = 154;
            // 
            // CashierPassword
            // 
            this.CashierPassword.Text = "Cashier Password";
            this.CashierPassword.Width = 176;
            // 
            // txtIdCashier
            // 
            this.txtIdCashier.Location = new System.Drawing.Point(157, 117);
            this.txtIdCashier.Name = "txtIdCashier";
            this.txtIdCashier.Size = new System.Drawing.Size(152, 20);
            this.txtIdCashier.TabIndex = 35;
            // 
            // txtCashierPassword
            // 
            this.txtCashierPassword.Location = new System.Drawing.Point(157, 234);
            this.txtCashierPassword.Name = "txtCashierPassword";
            this.txtCashierPassword.PasswordChar = '*';
            this.txtCashierPassword.Size = new System.Drawing.Size(152, 20);
            this.txtCashierPassword.TabIndex = 34;
            // 
            // txtCashierUsername
            // 
            this.txtCashierUsername.Location = new System.Drawing.Point(157, 205);
            this.txtCashierUsername.Name = "txtCashierUsername";
            this.txtCashierUsername.Size = new System.Drawing.Size(152, 20);
            this.txtCashierUsername.TabIndex = 33;
            // 
            // txtCashierSurname
            // 
            this.txtCashierSurname.Location = new System.Drawing.Point(157, 174);
            this.txtCashierSurname.Name = "txtCashierSurname";
            this.txtCashierSurname.Size = new System.Drawing.Size(152, 20);
            this.txtCashierSurname.TabIndex = 32;
            // 
            // txtCashierName
            // 
            this.txtCashierName.Location = new System.Drawing.Point(157, 145);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.Size = new System.Drawing.Size(152, 20);
            this.txtCashierName.TabIndex = 31;
            // 
            // CashierRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btnBackCashier);
            this.Controls.Add(this.btnUpdateCashier);
            this.Controls.Add(this.btnDeleteCashier);
            this.Controls.Add(this.btnAddCashier);
            this.Controls.Add(this.ShowCashier);
            this.Controls.Add(this.lblIdCashier);
            this.Controls.Add(this.lblCashierPassword);
            this.Controls.Add(this.lblCashierUsername);
            this.Controls.Add(this.lblCashierSurname);
            this.Controls.Add(this.lblCashierName);
            this.Controls.Add(this.listCashier);
            this.Controls.Add(this.txtIdCashier);
            this.Controls.Add(this.txtCashierPassword);
            this.Controls.Add(this.txtCashierUsername);
            this.Controls.Add(this.txtCashierSurname);
            this.Controls.Add(this.txtCashierName);
            this.DoubleBuffered = true;
            this.Name = "CashierRegistration";
            this.Text = "Cashier Registration Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackCashier;
        private System.Windows.Forms.Button btnUpdateCashier;
        private System.Windows.Forms.Button btnDeleteCashier;
        private System.Windows.Forms.Button btnAddCashier;
        private System.Windows.Forms.Button ShowCashier;
        private System.Windows.Forms.Label lblIdCashier;
        private System.Windows.Forms.Label lblCashierPassword;
        private System.Windows.Forms.Label lblCashierUsername;
        private System.Windows.Forms.Label lblCashierSurname;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.ListView listCashier;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader CashierName;
        private System.Windows.Forms.ColumnHeader CashierSurname;
        private System.Windows.Forms.ColumnHeader CashierUsername;
        private System.Windows.Forms.ColumnHeader CashierPassword;
        private System.Windows.Forms.TextBox txtIdCashier;
        private System.Windows.Forms.TextBox txtCashierPassword;
        private System.Windows.Forms.TextBox txtCashierUsername;
        private System.Windows.Forms.TextBox txtCashierSurname;
        private System.Windows.Forms.TextBox txtCashierName;
    }
}