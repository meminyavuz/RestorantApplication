namespace Restoran
{
    partial class LoginAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLogin = new System.Windows.Forms.Label();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.btnBackMainMenu4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(144, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Password:";
            // 
            // AdminLogin
            // 
            this.AdminLogin.AutoSize = true;
            this.AdminLogin.BackColor = System.Drawing.SystemColors.Control;
            this.AdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdminLogin.Location = new System.Drawing.Point(215, 127);
            this.AdminLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(277, 33);
            this.AdminLogin.TabIndex = 2;
            this.AdminLogin.Text = "Admin Login Screen";
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(282, 196);
            this.txtAdminUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(162, 21);
            this.txtAdminUserName.TabIndex = 3;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(282, 256);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(162, 21);
            this.txtAdminPassword.TabIndex = 4;
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Location = new System.Drawing.Point(282, 307);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(162, 66);
            this.AdminLoginButton.TabIndex = 5;
            this.AdminLoginButton.Text = "Login";
            this.AdminLoginButton.UseVisualStyleBackColor = true;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // btnBackMainMenu4
            // 
            this.btnBackMainMenu4.Location = new System.Drawing.Point(12, 12);
            this.btnBackMainMenu4.Name = "btnBackMainMenu4";
            this.btnBackMainMenu4.Size = new System.Drawing.Size(56, 44);
            this.btnBackMainMenu4.TabIndex = 48;
            this.btnBackMainMenu4.Text = "Back";
            this.btnBackMainMenu4.UseVisualStyleBackColor = true;
            this.btnBackMainMenu4.Click += new System.EventHandler(this.btnBackMainMenu4_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 458);
            this.Controls.Add(this.btnBackMainMenu4);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminUserName);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdminLogin;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Button btnBackMainMenu4;
    }
}