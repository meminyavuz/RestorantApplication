namespace Restoran
{
    partial class KitchenRegistration
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
            System.Windows.Forms.ColumnHeader ID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenRegistration));
            this.txtIdKitchen = new System.Windows.Forms.TextBox();
            this.txtKitchenPassword = new System.Windows.Forms.TextBox();
            this.txtKitchenUsername = new System.Windows.Forms.TextBox();
            this.txtKitchenSurname = new System.Windows.Forms.TextBox();
            this.txtKitchenName = new System.Windows.Forms.TextBox();
            this.listKitchen = new System.Windows.Forms.ListView();
            this.KitchenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitchenSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitchenUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitchenPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIdKitchen = new System.Windows.Forms.Label();
            this.lblKitchenPassword = new System.Windows.Forms.Label();
            this.lblKitchenUsername = new System.Windows.Forms.Label();
            this.lblKitchenSurname = new System.Windows.Forms.Label();
            this.lblKitchenName = new System.Windows.Forms.Label();
            this.btnUpdateKitchen = new System.Windows.Forms.Button();
            this.btnDeleteKitchen = new System.Windows.Forms.Button();
            this.btnAddKitchen = new System.Windows.Forms.Button();
            this.ShowKitchens = new System.Windows.Forms.Button();
            this.btnBackKitchen = new System.Windows.Forms.Button();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 38;
            // 
            // txtIdKitchen
            // 
            this.txtIdKitchen.Location = new System.Drawing.Point(153, 116);
            this.txtIdKitchen.Name = "txtIdKitchen";
            this.txtIdKitchen.Size = new System.Drawing.Size(152, 20);
            this.txtIdKitchen.TabIndex = 19;
            
            // 
            // txtKitchenPassword
            // 
            this.txtKitchenPassword.Location = new System.Drawing.Point(153, 233);
            this.txtKitchenPassword.Name = "txtKitchenPassword";
            this.txtKitchenPassword.PasswordChar = '*';
            this.txtKitchenPassword.Size = new System.Drawing.Size(152, 20);
            this.txtKitchenPassword.TabIndex = 18;
            // 
            // txtKitchenUsername
            // 
            this.txtKitchenUsername.Location = new System.Drawing.Point(153, 204);
            this.txtKitchenUsername.Name = "txtKitchenUsername";
            this.txtKitchenUsername.Size = new System.Drawing.Size(152, 20);
            this.txtKitchenUsername.TabIndex = 17;
            // 
            // txtKitchenSurname
            // 
            this.txtKitchenSurname.Location = new System.Drawing.Point(153, 173);
            this.txtKitchenSurname.Name = "txtKitchenSurname";
            this.txtKitchenSurname.Size = new System.Drawing.Size(152, 20);
            this.txtKitchenSurname.TabIndex = 16;
            // 
            // txtKitchenName
            // 
            this.txtKitchenName.Location = new System.Drawing.Point(153, 144);
            this.txtKitchenName.Name = "txtKitchenName";
            this.txtKitchenName.Size = new System.Drawing.Size(152, 20);
            this.txtKitchenName.TabIndex = 15;
            // 
            // listKitchen
            // 
            this.listKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ID,
            this.KitchenName,
            this.KitchenSurname,
            this.KitchenUsername,
            this.KitchenPassword});
            this.listKitchen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listKitchen.HideSelection = false;
            this.listKitchen.Location = new System.Drawing.Point(12, 271);
            this.listKitchen.Name = "listKitchen";
            this.listKitchen.Size = new System.Drawing.Size(712, 165);
            this.listKitchen.TabIndex = 20;
            this.listKitchen.UseCompatibleStateImageBehavior = false;
            this.listKitchen.View = System.Windows.Forms.View.Details;
            this.listKitchen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listKitchen_MouseDoubleClick);
            // 
            // KitchenName
            // 
            this.KitchenName.Text = "Kitchen Name";
            this.KitchenName.Width = 164;
            // 
            // KitchenSurname
            // 
            this.KitchenSurname.Text = "Kitchen Surname";
            this.KitchenSurname.Width = 175;
            // 
            // KitchenUsername
            // 
            this.KitchenUsername.Text = "Kitchen Username";
            this.KitchenUsername.Width = 154;
            // 
            // KitchenPassword
            // 
            this.KitchenPassword.Text = "Kitchen Password";
            this.KitchenPassword.Width = 176;
            // 
            // lblIdKitchen
            // 
            this.lblIdKitchen.AutoSize = true;
            this.lblIdKitchen.BackColor = System.Drawing.Color.Transparent;
            this.lblIdKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdKitchen.ForeColor = System.Drawing.Color.LightCyan;
            this.lblIdKitchen.Location = new System.Drawing.Point(117, 116);
            this.lblIdKitchen.Name = "lblIdKitchen";
            this.lblIdKitchen.Size = new System.Drawing.Size(30, 20);
            this.lblIdKitchen.TabIndex = 25;
            this.lblIdKitchen.Text = "ID:";
            // 
            // lblKitchenPassword
            // 
            this.lblKitchenPassword.AutoSize = true;
            this.lblKitchenPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitchenPassword.ForeColor = System.Drawing.Color.LightCyan;
            this.lblKitchenPassword.Location = new System.Drawing.Point(15, 231);
            this.lblKitchenPassword.Name = "lblKitchenPassword";
            this.lblKitchenPassword.Size = new System.Drawing.Size(139, 20);
            this.lblKitchenPassword.TabIndex = 24;
            this.lblKitchenPassword.Text = "Kitchen Password:";
            // 
            // lblKitchenUsername
            // 
            this.lblKitchenUsername.AutoSize = true;
            this.lblKitchenUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitchenUsername.ForeColor = System.Drawing.Color.LightCyan;
            this.lblKitchenUsername.Location = new System.Drawing.Point(10, 202);
            this.lblKitchenUsername.Name = "lblKitchenUsername";
            this.lblKitchenUsername.Size = new System.Drawing.Size(144, 20);
            this.lblKitchenUsername.TabIndex = 23;
            this.lblKitchenUsername.Text = "Kitchen Username:";
            // 
            // lblKitchenSurname
            // 
            this.lblKitchenSurname.AutoSize = true;
            this.lblKitchenSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitchenSurname.ForeColor = System.Drawing.Color.LightCyan;
            this.lblKitchenSurname.Location = new System.Drawing.Point(19, 171);
            this.lblKitchenSurname.Name = "lblKitchenSurname";
            this.lblKitchenSurname.Size = new System.Drawing.Size(135, 20);
            this.lblKitchenSurname.TabIndex = 22;
            this.lblKitchenSurname.Text = "Kitchen Surname:";
            // 
            // lblKitchenName
            // 
            this.lblKitchenName.AutoSize = true;
            this.lblKitchenName.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitchenName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblKitchenName.Location = new System.Drawing.Point(42, 142);
            this.lblKitchenName.Name = "lblKitchenName";
            this.lblKitchenName.Size = new System.Drawing.Size(112, 20);
            this.lblKitchenName.TabIndex = 21;
            this.lblKitchenName.Text = "Kitchen Name:";
            // 
            // btnUpdateKitchen
            // 
            this.btnUpdateKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateKitchen.Location = new System.Drawing.Point(486, 228);
            this.btnUpdateKitchen.Name = "btnUpdateKitchen";
            this.btnUpdateKitchen.Size = new System.Drawing.Size(116, 32);
            this.btnUpdateKitchen.TabIndex = 29;
            this.btnUpdateKitchen.Text = "Update Kitchen";
            this.btnUpdateKitchen.UseVisualStyleBackColor = true;
            this.btnUpdateKitchen.Click += new System.EventHandler(this.btnUpdateKitchen_Click);
            // 
            // btnDeleteKitchen
            // 
            this.btnDeleteKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteKitchen.Location = new System.Drawing.Point(608, 152);
            this.btnDeleteKitchen.Name = "btnDeleteKitchen";
            this.btnDeleteKitchen.Size = new System.Drawing.Size(116, 58);
            this.btnDeleteKitchen.TabIndex = 28;
            this.btnDeleteKitchen.Text = "Delete Kitchen";
            this.btnDeleteKitchen.UseVisualStyleBackColor = true;
            this.btnDeleteKitchen.Click += new System.EventHandler(this.btnDeleteKitchen_Click);
            // 
            // btnAddKitchen
            // 
            this.btnAddKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddKitchen.Location = new System.Drawing.Point(608, 88);
            this.btnAddKitchen.Name = "btnAddKitchen";
            this.btnAddKitchen.Size = new System.Drawing.Size(116, 58);
            this.btnAddKitchen.TabIndex = 27;
            this.btnAddKitchen.Text = "Add Kitchen";
            this.btnAddKitchen.UseVisualStyleBackColor = true;
            this.btnAddKitchen.Click += new System.EventHandler(this.btnAddKitchen_Click);
            // 
            // ShowKitchens
            // 
            this.ShowKitchens.Location = new System.Drawing.Point(608, 228);
            this.ShowKitchens.Name = "ShowKitchens";
            this.ShowKitchens.Size = new System.Drawing.Size(116, 32);
            this.ShowKitchens.TabIndex = 26;
            this.ShowKitchens.Text = "Show Kitchen(s)";
            this.ShowKitchens.UseVisualStyleBackColor = true;
            this.ShowKitchens.Click += new System.EventHandler(this.ShowKitchens_Click);
            // 
            // btnBackKitchen
            // 
            this.btnBackKitchen.Location = new System.Drawing.Point(12, 12);
            this.btnBackKitchen.Name = "btnBackKitchen";
            this.btnBackKitchen.Size = new System.Drawing.Size(56, 44);
            this.btnBackKitchen.TabIndex = 30;
            this.btnBackKitchen.Text = "Back";
            this.btnBackKitchen.UseVisualStyleBackColor = true;
            this.btnBackKitchen.Click += new System.EventHandler(this.btnBackKitchen_Click);
            // 
            // KitchenRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnBackKitchen);
            this.Controls.Add(this.btnUpdateKitchen);
            this.Controls.Add(this.btnDeleteKitchen);
            this.Controls.Add(this.btnAddKitchen);
            this.Controls.Add(this.ShowKitchens);
            this.Controls.Add(this.lblIdKitchen);
            this.Controls.Add(this.lblKitchenPassword);
            this.Controls.Add(this.lblKitchenUsername);
            this.Controls.Add(this.lblKitchenSurname);
            this.Controls.Add(this.lblKitchenName);
            this.Controls.Add(this.listKitchen);
            this.Controls.Add(this.txtIdKitchen);
            this.Controls.Add(this.txtKitchenPassword);
            this.Controls.Add(this.txtKitchenUsername);
            this.Controls.Add(this.txtKitchenSurname);
            this.Controls.Add(this.txtKitchenName);
            this.DoubleBuffered = true;
            this.Name = "KitchenRegistration";
            this.Text = "KitchenRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdKitchen;
        private System.Windows.Forms.TextBox txtKitchenPassword;
        private System.Windows.Forms.TextBox txtKitchenUsername;
        private System.Windows.Forms.TextBox txtKitchenSurname;
        private System.Windows.Forms.TextBox txtKitchenName;
        private System.Windows.Forms.ListView listKitchen;
        private System.Windows.Forms.ColumnHeader KitchenName;
        private System.Windows.Forms.ColumnHeader KitchenSurname;
        private System.Windows.Forms.ColumnHeader KitchenUsername;
        private System.Windows.Forms.ColumnHeader KitchenPassword;
        private System.Windows.Forms.Label lblIdKitchen;
        private System.Windows.Forms.Label lblKitchenPassword;
        private System.Windows.Forms.Label lblKitchenUsername;
        private System.Windows.Forms.Label lblKitchenSurname;
        private System.Windows.Forms.Label lblKitchenName;
        private System.Windows.Forms.Button btnUpdateKitchen;
        private System.Windows.Forms.Button btnDeleteKitchen;
        private System.Windows.Forms.Button btnAddKitchen;
        private System.Windows.Forms.Button ShowKitchens;
        private System.Windows.Forms.Button btnBackKitchen;
    }
}