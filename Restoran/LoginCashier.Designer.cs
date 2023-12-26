namespace Restoran
{
    partial class LoginCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCashier));
            this.btnCashierLogin = new System.Windows.Forms.Button();
            this.lblCashierLoginPassword = new System.Windows.Forms.Label();
            this.lblCashierLoginUsername = new System.Windows.Forms.Label();
            this.txtCashierLoginPassword = new System.Windows.Forms.TextBox();
            this.txtCashierLoginUserName = new System.Windows.Forms.TextBox();
            this.btnBackMainMenu3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCashierLogin
            // 
            this.btnCashierLogin.Location = new System.Drawing.Point(318, 249);
            this.btnCashierLogin.Name = "btnCashierLogin";
            this.btnCashierLogin.Size = new System.Drawing.Size(162, 65);
            this.btnCashierLogin.TabIndex = 16;
            this.btnCashierLogin.Text = "Login";
            this.btnCashierLogin.UseVisualStyleBackColor = true;
            this.btnCashierLogin.Click += new System.EventHandler(this.btnCashierLogin_Click);
            // 
            // lblCashierLoginPassword
            // 
            this.lblCashierLoginPassword.AutoSize = true;
            this.lblCashierLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierLoginPassword.Location = new System.Drawing.Point(154, 196);
            this.lblCashierLoginPassword.Name = "lblCashierLoginPassword";
            this.lblCashierLoginPassword.Size = new System.Drawing.Size(157, 20);
            this.lblCashierLoginPassword.TabIndex = 15;
            this.lblCashierLoginPassword.Text = "Cashier Password:";
            // 
            // lblCashierLoginUsername
            // 
            this.lblCashierLoginUsername.AutoSize = true;
            this.lblCashierLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashierLoginUsername.Location = new System.Drawing.Point(149, 136);
            this.lblCashierLoginUsername.Name = "lblCashierLoginUsername";
            this.lblCashierLoginUsername.Size = new System.Drawing.Size(162, 20);
            this.lblCashierLoginUsername.TabIndex = 14;
            this.lblCashierLoginUsername.Text = "Cashier Username:";
            // 
            // txtCashierLoginPassword
            // 
            this.txtCashierLoginPassword.Location = new System.Drawing.Point(318, 196);
            this.txtCashierLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashierLoginPassword.Name = "txtCashierLoginPassword";
            this.txtCashierLoginPassword.PasswordChar = '*';
            this.txtCashierLoginPassword.Size = new System.Drawing.Size(162, 20);
            this.txtCashierLoginPassword.TabIndex = 13;
            // 
            // txtCashierLoginUserName
            // 
            this.txtCashierLoginUserName.Location = new System.Drawing.Point(318, 136);
            this.txtCashierLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashierLoginUserName.Name = "txtCashierLoginUserName";
            this.txtCashierLoginUserName.Size = new System.Drawing.Size(162, 20);
            this.txtCashierLoginUserName.TabIndex = 12;
            // 
            // btnBackMainMenu3
            // 
            this.btnBackMainMenu3.Location = new System.Drawing.Point(12, 12);
            this.btnBackMainMenu3.Name = "btnBackMainMenu3";
            this.btnBackMainMenu3.Size = new System.Drawing.Size(56, 44);
            this.btnBackMainMenu3.TabIndex = 48;
            this.btnBackMainMenu3.Text = "Back";
            this.btnBackMainMenu3.UseVisualStyleBackColor = true;
            this.btnBackMainMenu3.Click += new System.EventHandler(this.btnBackMainMenu3_Click);
            // 
            // LoginCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.btnBackMainMenu3);
            this.Controls.Add(this.btnCashierLogin);
            this.Controls.Add(this.lblCashierLoginPassword);
            this.Controls.Add(this.lblCashierLoginUsername);
            this.Controls.Add(this.txtCashierLoginPassword);
            this.Controls.Add(this.txtCashierLoginUserName);
            this.DoubleBuffered = true;
            this.Name = "LoginCashier";
            this.Text = "LoginCashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashierLogin;
        private System.Windows.Forms.Label lblCashierLoginPassword;
        private System.Windows.Forms.Label lblCashierLoginUsername;
        private System.Windows.Forms.TextBox txtCashierLoginPassword;
        private System.Windows.Forms.TextBox txtCashierLoginUserName;
        private System.Windows.Forms.Button btnBackMainMenu3;
    }
}