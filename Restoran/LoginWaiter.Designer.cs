namespace Restoran
{
    partial class LoginWaiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWaiter));
            this.txtWaiterLoginPassword = new System.Windows.Forms.TextBox();
            this.txtWaiterLoginUserName = new System.Windows.Forms.TextBox();
            this.lblWaiterLoginUsername = new System.Windows.Forms.Label();
            this.lblWaiterLoginPassword = new System.Windows.Forms.Label();
            this.btnWaiterLogin = new System.Windows.Forms.Button();
            this.btnBackMainMenu1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWaiterLoginPassword
            // 
            this.txtWaiterLoginPassword.Location = new System.Drawing.Point(314, 242);
            this.txtWaiterLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterLoginPassword.Name = "txtWaiterLoginPassword";
            this.txtWaiterLoginPassword.PasswordChar = '*';
            this.txtWaiterLoginPassword.Size = new System.Drawing.Size(162, 20);
            this.txtWaiterLoginPassword.TabIndex = 8;
            // 
            // txtWaiterLoginUserName
            // 
            this.txtWaiterLoginUserName.Location = new System.Drawing.Point(314, 182);
            this.txtWaiterLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterLoginUserName.Name = "txtWaiterLoginUserName";
            this.txtWaiterLoginUserName.Size = new System.Drawing.Size(162, 20);
            this.txtWaiterLoginUserName.TabIndex = 7;
            // 
            // lblWaiterLoginUsername
            // 
            this.lblWaiterLoginUsername.AutoSize = true;
            this.lblWaiterLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterLoginUsername.Location = new System.Drawing.Point(154, 182);
            this.lblWaiterLoginUsername.Name = "lblWaiterLoginUsername";
            this.lblWaiterLoginUsername.Size = new System.Drawing.Size(153, 20);
            this.lblWaiterLoginUsername.TabIndex = 9;
            this.lblWaiterLoginUsername.Text = "Waiter Username:";
            // 
            // lblWaiterLoginPassword
            // 
            this.lblWaiterLoginPassword.AutoSize = true;
            this.lblWaiterLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterLoginPassword.Location = new System.Drawing.Point(159, 242);
            this.lblWaiterLoginPassword.Name = "lblWaiterLoginPassword";
            this.lblWaiterLoginPassword.Size = new System.Drawing.Size(148, 20);
            this.lblWaiterLoginPassword.TabIndex = 10;
            this.lblWaiterLoginPassword.Text = "Waiter Password:";
            // 
            // btnWaiterLogin
            // 
            this.btnWaiterLogin.Location = new System.Drawing.Point(314, 295);
            this.btnWaiterLogin.Name = "btnWaiterLogin";
            this.btnWaiterLogin.Size = new System.Drawing.Size(162, 65);
            this.btnWaiterLogin.TabIndex = 11;
            this.btnWaiterLogin.Text = "Login";
            this.btnWaiterLogin.UseVisualStyleBackColor = true;
            this.btnWaiterLogin.Click += new System.EventHandler(this.btnWaiterLogin_Click);
            // 
            // btnBackMainMenu1
            // 
            this.btnBackMainMenu1.Location = new System.Drawing.Point(12, 12);
            this.btnBackMainMenu1.Name = "btnBackMainMenu1";
            this.btnBackMainMenu1.Size = new System.Drawing.Size(56, 44);
            this.btnBackMainMenu1.TabIndex = 48;
            this.btnBackMainMenu1.Text = "Back";
            this.btnBackMainMenu1.UseVisualStyleBackColor = true;
            this.btnBackMainMenu1.Click += new System.EventHandler(this.btnBackMainMenu1_Click);
            // 
            // LoginWaiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnBackMainMenu1);
            this.Controls.Add(this.btnWaiterLogin);
            this.Controls.Add(this.lblWaiterLoginPassword);
            this.Controls.Add(this.lblWaiterLoginUsername);
            this.Controls.Add(this.txtWaiterLoginPassword);
            this.Controls.Add(this.txtWaiterLoginUserName);
            this.DoubleBuffered = true;
            this.Name = "LoginWaiter";
            this.Text = "LoginWaiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWaiterLoginPassword;
        private System.Windows.Forms.TextBox txtWaiterLoginUserName;
        private System.Windows.Forms.Label lblWaiterLoginUsername;
        private System.Windows.Forms.Label lblWaiterLoginPassword;
        private System.Windows.Forms.Button btnWaiterLogin;
        private System.Windows.Forms.Button btnBackMainMenu1;
    }
}