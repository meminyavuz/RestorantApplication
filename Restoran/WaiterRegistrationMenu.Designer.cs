namespace Restoran
{
    partial class WaiterRegistrationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterRegistrationMenu));
            this.listWaiter = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaiterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaiterSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaiterUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaiterPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowWaiters = new System.Windows.Forms.Button();
            this.lblWaiterName = new System.Windows.Forms.Label();
            this.lblWaiterSurname = new System.Windows.Forms.Label();
            this.lblWaiterUsername = new System.Windows.Forms.Label();
            this.lblWaiterPassword = new System.Windows.Forms.Label();
            this.txtWaiterName = new System.Windows.Forms.TextBox();
            this.txtWaiterSurname = new System.Windows.Forms.TextBox();
            this.txtWaiterUsername = new System.Windows.Forms.TextBox();
            this.txtWaiterPassword = new System.Windows.Forms.TextBox();
            this.btnAddWaiter = new System.Windows.Forms.Button();
            this.btnDeleteWaiter = new System.Windows.Forms.Button();
            this.btnUpdateWaiter = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdWaiter = new System.Windows.Forms.TextBox();
            this.btnBackWaiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listWaiter
            // 
            this.listWaiter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.WaiterName,
            this.WaiterSurname,
            this.WaiterUsername,
            this.WaiterPassword});
            this.listWaiter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listWaiter.HideSelection = false;
            this.listWaiter.Location = new System.Drawing.Point(12, 273);
            this.listWaiter.Name = "listWaiter";
            this.listWaiter.Size = new System.Drawing.Size(712, 165);
            this.listWaiter.TabIndex = 0;
            this.listWaiter.UseCompatibleStateImageBehavior = false;
            this.listWaiter.View = System.Windows.Forms.View.Details;
            this.listWaiter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listWaiter_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 38;
            // 
            // WaiterName
            // 
            this.WaiterName.Text = "Waiter Name";
            this.WaiterName.Width = 164;
            // 
            // WaiterSurname
            // 
            this.WaiterSurname.Text = "Waiter Surname";
            this.WaiterSurname.Width = 175;
            // 
            // WaiterUsername
            // 
            this.WaiterUsername.Text = "Waiter Username";
            this.WaiterUsername.Width = 154;
            // 
            // WaiterPassword
            // 
            this.WaiterPassword.Text = "Waiter Password";
            this.WaiterPassword.Width = 176;
            // 
            // ShowWaiters
            // 
            this.ShowWaiters.Location = new System.Drawing.Point(608, 235);
            this.ShowWaiters.Name = "ShowWaiters";
            this.ShowWaiters.Size = new System.Drawing.Size(116, 32);
            this.ShowWaiters.TabIndex = 1;
            this.ShowWaiters.Text = "Show Waiter(s)";
            this.ShowWaiters.UseVisualStyleBackColor = true;
            this.ShowWaiters.Click += new System.EventHandler(this.ShowWaiters_Click);
            // 
            // lblWaiterName
            // 
            this.lblWaiterName.AutoSize = true;
            this.lblWaiterName.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblWaiterName.Location = new System.Drawing.Point(42, 140);
            this.lblWaiterName.Name = "lblWaiterName";
            this.lblWaiterName.Size = new System.Drawing.Size(105, 20);
            this.lblWaiterName.TabIndex = 2;
            this.lblWaiterName.Text = "Waiter Name:";
            // 
            // lblWaiterSurname
            // 
            this.lblWaiterSurname.AutoSize = true;
            this.lblWaiterSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterSurname.ForeColor = System.Drawing.Color.LightCyan;
            this.lblWaiterSurname.Location = new System.Drawing.Point(19, 169);
            this.lblWaiterSurname.Name = "lblWaiterSurname";
            this.lblWaiterSurname.Size = new System.Drawing.Size(128, 20);
            this.lblWaiterSurname.TabIndex = 3;
            this.lblWaiterSurname.Text = "Waiter Surname:";
            // 
            // lblWaiterUsername
            // 
            this.lblWaiterUsername.AutoSize = true;
            this.lblWaiterUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterUsername.ForeColor = System.Drawing.Color.LightCyan;
            this.lblWaiterUsername.Location = new System.Drawing.Point(10, 200);
            this.lblWaiterUsername.Name = "lblWaiterUsername";
            this.lblWaiterUsername.Size = new System.Drawing.Size(137, 20);
            this.lblWaiterUsername.TabIndex = 4;
            this.lblWaiterUsername.Text = "Waiter Username:";
            // 
            // lblWaiterPassword
            // 
            this.lblWaiterPassword.AutoSize = true;
            this.lblWaiterPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterPassword.ForeColor = System.Drawing.Color.LightCyan;
            this.lblWaiterPassword.Location = new System.Drawing.Point(15, 229);
            this.lblWaiterPassword.Name = "lblWaiterPassword";
            this.lblWaiterPassword.Size = new System.Drawing.Size(132, 20);
            this.lblWaiterPassword.TabIndex = 5;
            this.lblWaiterPassword.Text = "Waiter Password:";
            // 
            // txtWaiterName
            // 
            this.txtWaiterName.Location = new System.Drawing.Point(153, 142);
            this.txtWaiterName.Name = "txtWaiterName";
            this.txtWaiterName.Size = new System.Drawing.Size(152, 20);
            this.txtWaiterName.TabIndex = 6;
            // 
            // txtWaiterSurname
            // 
            this.txtWaiterSurname.Location = new System.Drawing.Point(153, 171);
            this.txtWaiterSurname.Name = "txtWaiterSurname";
            this.txtWaiterSurname.Size = new System.Drawing.Size(152, 20);
            this.txtWaiterSurname.TabIndex = 7;
            // 
            // txtWaiterUsername
            // 
            this.txtWaiterUsername.Location = new System.Drawing.Point(153, 200);
            this.txtWaiterUsername.Name = "txtWaiterUsername";
            this.txtWaiterUsername.Size = new System.Drawing.Size(152, 20);
            this.txtWaiterUsername.TabIndex = 8;
            // 
            // txtWaiterPassword
            // 
            this.txtWaiterPassword.Location = new System.Drawing.Point(153, 231);
            this.txtWaiterPassword.Name = "txtWaiterPassword";
            this.txtWaiterPassword.PasswordChar = '*';
            this.txtWaiterPassword.Size = new System.Drawing.Size(152, 20);
            this.txtWaiterPassword.TabIndex = 9;
            // 
            // btnAddWaiter
            // 
            this.btnAddWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddWaiter.Location = new System.Drawing.Point(608, 85);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(116, 58);
            this.btnAddWaiter.TabIndex = 10;
            this.btnAddWaiter.Text = "Add Waiter";
            this.btnAddWaiter.UseVisualStyleBackColor = true;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // btnDeleteWaiter
            // 
            this.btnDeleteWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteWaiter.Location = new System.Drawing.Point(608, 152);
            this.btnDeleteWaiter.Name = "btnDeleteWaiter";
            this.btnDeleteWaiter.Size = new System.Drawing.Size(116, 58);
            this.btnDeleteWaiter.TabIndex = 11;
            this.btnDeleteWaiter.Text = "Delete Waiter";
            this.btnDeleteWaiter.UseVisualStyleBackColor = true;
            this.btnDeleteWaiter.Click += new System.EventHandler(this.btnDeleteWaiter_Click);
            // 
            // btnUpdateWaiter
            // 
            this.btnUpdateWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateWaiter.Location = new System.Drawing.Point(486, 235);
            this.btnUpdateWaiter.Name = "btnUpdateWaiter";
            this.btnUpdateWaiter.Size = new System.Drawing.Size(116, 32);
            this.btnUpdateWaiter.TabIndex = 12;
            this.btnUpdateWaiter.Text = "Update Waiter";
            this.btnUpdateWaiter.UseVisualStyleBackColor = true;
            this.btnUpdateWaiter.Click += new System.EventHandler(this.btnUpdateWaiter_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.LightCyan;
            this.lblId.Location = new System.Drawing.Point(117, 114);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID:";
            // 
            // txtIdWaiter
            // 
            this.txtIdWaiter.Location = new System.Drawing.Point(153, 114);
            this.txtIdWaiter.Name = "txtIdWaiter";
            this.txtIdWaiter.Size = new System.Drawing.Size(152, 20);
            this.txtIdWaiter.TabIndex = 14;
            // 
            // btnBackWaiter
            // 
            this.btnBackWaiter.Location = new System.Drawing.Point(12, 28);
            this.btnBackWaiter.Name = "btnBackWaiter";
            this.btnBackWaiter.Size = new System.Drawing.Size(56, 44);
            this.btnBackWaiter.TabIndex = 15;
            this.btnBackWaiter.Text = "Back";
            this.btnBackWaiter.UseVisualStyleBackColor = true;
            this.btnBackWaiter.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WaiterRegistrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.btnBackWaiter);
            this.Controls.Add(this.txtIdWaiter);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnUpdateWaiter);
            this.Controls.Add(this.btnDeleteWaiter);
            this.Controls.Add(this.btnAddWaiter);
            this.Controls.Add(this.txtWaiterPassword);
            this.Controls.Add(this.txtWaiterUsername);
            this.Controls.Add(this.txtWaiterSurname);
            this.Controls.Add(this.txtWaiterName);
            this.Controls.Add(this.lblWaiterPassword);
            this.Controls.Add(this.lblWaiterUsername);
            this.Controls.Add(this.lblWaiterSurname);
            this.Controls.Add(this.lblWaiterName);
            this.Controls.Add(this.ShowWaiters);
            this.Controls.Add(this.listWaiter);
            this.DoubleBuffered = true;
            this.Name = "WaiterRegistrationMenu";
            this.Text = "WaiterRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listWaiter;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader WaiterName;
        private System.Windows.Forms.ColumnHeader WaiterSurname;
        private System.Windows.Forms.ColumnHeader WaiterUsername;
        private System.Windows.Forms.ColumnHeader WaiterPassword;
        private System.Windows.Forms.Button ShowWaiters;
        private System.Windows.Forms.Label lblWaiterName;
        private System.Windows.Forms.Label lblWaiterSurname;
        private System.Windows.Forms.Label lblWaiterUsername;
        private System.Windows.Forms.Label lblWaiterPassword;
        private System.Windows.Forms.TextBox txtWaiterName;
        private System.Windows.Forms.TextBox txtWaiterSurname;
        private System.Windows.Forms.TextBox txtWaiterUsername;
        private System.Windows.Forms.TextBox txtWaiterPassword;
        private System.Windows.Forms.Button btnAddWaiter;
        private System.Windows.Forms.Button btnDeleteWaiter;
        private System.Windows.Forms.Button btnUpdateWaiter;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdWaiter;
        private System.Windows.Forms.Button btnBackWaiter;
    }
}