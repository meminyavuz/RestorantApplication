namespace Restoran
{
    partial class LoginKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginKitchen));
            this.btnKitchenLogin = new System.Windows.Forms.Button();
            this.lblKitchenLoginPassword = new System.Windows.Forms.Label();
            this.lblKitchenLoginUsername = new System.Windows.Forms.Label();
            this.txtKitchenLoginPassword = new System.Windows.Forms.TextBox();
            this.txtKitchenLoginUserName = new System.Windows.Forms.TextBox();
            this.btnBackMainMenu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitchenLogin
            // 
            this.btnKitchenLogin.Location = new System.Drawing.Point(326, 363);
            this.btnKitchenLogin.Name = "btnKitchenLogin";
            this.btnKitchenLogin.Size = new System.Drawing.Size(162, 65);
            this.btnKitchenLogin.TabIndex = 16;
            this.btnKitchenLogin.Text = "Login";
            this.btnKitchenLogin.UseVisualStyleBackColor = true;
            this.btnKitchenLogin.Click += new System.EventHandler(this.btnKitchenLogin_Click);
            // 
            // lblKitchenLoginPassword
            // 
            this.lblKitchenLoginPassword.AutoSize = true;
            this.lblKitchenLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitchenLoginPassword.Location = new System.Drawing.Point(163, 310);
            this.lblKitchenLoginPassword.Name = "lblKitchenLoginPassword";
            this.lblKitchenLoginPassword.Size = new System.Drawing.Size(156, 20);
            this.lblKitchenLoginPassword.TabIndex = 15;
            this.lblKitchenLoginPassword.Text = "Kitchen Password:";
            // 
            // lblKitchenLoginUsername
            // 
            this.lblKitchenLoginUsername.AutoSize = true;
            this.lblKitchenLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitchenLoginUsername.Location = new System.Drawing.Point(158, 250);
            this.lblKitchenLoginUsername.Name = "lblKitchenLoginUsername";
            this.lblKitchenLoginUsername.Size = new System.Drawing.Size(161, 20);
            this.lblKitchenLoginUsername.TabIndex = 14;
            this.lblKitchenLoginUsername.Text = "Kitchen Username:";
            // 
            // txtKitchenLoginPassword
            // 
            this.txtKitchenLoginPassword.Location = new System.Drawing.Point(326, 310);
            this.txtKitchenLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitchenLoginPassword.Name = "txtKitchenLoginPassword";
            this.txtKitchenLoginPassword.PasswordChar = '*';
            this.txtKitchenLoginPassword.Size = new System.Drawing.Size(162, 20);
            this.txtKitchenLoginPassword.TabIndex = 13;
            // 
            // txtKitchenLoginUserName
            // 
            this.txtKitchenLoginUserName.Location = new System.Drawing.Point(326, 250);
            this.txtKitchenLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitchenLoginUserName.Name = "txtKitchenLoginUserName";
            this.txtKitchenLoginUserName.Size = new System.Drawing.Size(162, 20);
            this.txtKitchenLoginUserName.TabIndex = 12;
            // 
            // btnBackMainMenu2
            // 
            this.btnBackMainMenu2.Location = new System.Drawing.Point(12, 12);
            this.btnBackMainMenu2.Name = "btnBackMainMenu2";
            this.btnBackMainMenu2.Size = new System.Drawing.Size(56, 44);
            this.btnBackMainMenu2.TabIndex = 48;
            this.btnBackMainMenu2.Text = "Back";
            this.btnBackMainMenu2.UseVisualStyleBackColor = true;
            this.btnBackMainMenu2.Click += new System.EventHandler(this.btnBackMainMenu2_Click);
            // 
            // LoginKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 497);
            this.Controls.Add(this.btnBackMainMenu2);
            this.Controls.Add(this.btnKitchenLogin);
            this.Controls.Add(this.lblKitchenLoginPassword);
            this.Controls.Add(this.lblKitchenLoginUsername);
            this.Controls.Add(this.txtKitchenLoginPassword);
            this.Controls.Add(this.txtKitchenLoginUserName);
            this.DoubleBuffered = true;
            this.Name = "LoginKitchen";
            this.Text = "LoginKitchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKitchenLogin;
        private System.Windows.Forms.Label lblKitchenLoginPassword;
        private System.Windows.Forms.Label lblKitchenLoginUsername;
        private System.Windows.Forms.TextBox txtKitchenLoginPassword;
        private System.Windows.Forms.TextBox txtKitchenLoginUserName;
        private System.Windows.Forms.Button btnBackMainMenu2;
    }
}