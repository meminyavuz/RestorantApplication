namespace Restoran
{
    partial class OrderConfirmationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderConfirmationScreen));
            this.listOrder = new System.Windows.Forms.ListView();
            this.IDaddisyon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleMenuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleMenuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleMenuPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.txtIdOrder = new System.Windows.Forms.TextBox();
            this.lblIdOrder = new System.Windows.Forms.Label();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtMenuNo = new System.Windows.Forms.TextBox();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnBackKitchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOrder
            // 
            this.listOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDaddisyon,
            this.TableNo,
            this.SaleMenuNo,
            this.SaleMenuName,
            this.SaleMenuPrice});
            this.listOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listOrder.HideSelection = false;
            this.listOrder.Location = new System.Drawing.Point(95, 348);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(538, 165);
            this.listOrder.TabIndex = 10;
            this.listOrder.UseCompatibleStateImageBehavior = false;
            this.listOrder.View = System.Windows.Forms.View.Details;
            this.listOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOrder_MouseDoubleClick);
            // 
            // IDaddisyon
            // 
            this.IDaddisyon.Text = "ID";
            this.IDaddisyon.Width = 37;
            // 
            // TableNo
            // 
            this.TableNo.Text = "TableNo";
            this.TableNo.Width = 57;
            // 
            // SaleMenuNo
            // 
            this.SaleMenuNo.Text = "Menu No";
            this.SaleMenuNo.Width = 65;
            // 
            // SaleMenuName
            // 
            this.SaleMenuName.Text = "MenuName";
            this.SaleMenuName.Width = 145;
            // 
            // SaleMenuPrice
            // 
            this.SaleMenuPrice.Text = "Menu Price";
            this.SaleMenuPrice.Width = 111;
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Location = new System.Drawing.Point(527, 284);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(106, 58);
            this.btnShowOrder.TabIndex = 16;
            this.btnShowOrder.Text = "Show Order(s)";
            this.btnShowOrder.UseVisualStyleBackColor = true;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // txtIdOrder
            // 
            this.txtIdOrder.Location = new System.Drawing.Point(51, 121);
            this.txtIdOrder.Name = "txtIdOrder";
            this.txtIdOrder.ReadOnly = true;
            this.txtIdOrder.Size = new System.Drawing.Size(46, 20);
            this.txtIdOrder.TabIndex = 26;
            // 
            // lblIdOrder
            // 
            this.lblIdOrder.AutoSize = true;
            this.lblIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdOrder.Location = new System.Drawing.Point(12, 121);
            this.lblIdOrder.Name = "lblIdOrder";
            this.lblIdOrder.Size = new System.Drawing.Size(33, 20);
            this.lblIdOrder.TabIndex = 25;
            this.lblIdOrder.Text = "ID:";
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(103, 301);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.ReadOnly = true;
            this.txtMenuPrice.Size = new System.Drawing.Size(65, 20);
            this.txtMenuPrice.TabIndex = 24;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(103, 253);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.ReadOnly = true;
            this.txtMenuName.Size = new System.Drawing.Size(92, 20);
            this.txtMenuName.TabIndex = 23;
            // 
            // txtMenuNo
            // 
            this.txtMenuNo.Location = new System.Drawing.Point(103, 205);
            this.txtMenuNo.Name = "txtMenuNo";
            this.txtMenuNo.ReadOnly = true;
            this.txtMenuNo.Size = new System.Drawing.Size(65, 20);
            this.txtMenuNo.TabIndex = 22;
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(103, 159);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.ReadOnly = true;
            this.txtTableNo.Size = new System.Drawing.Size(65, 20);
            this.txtTableNo.TabIndex = 21;
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuPrice.Location = new System.Drawing.Point(12, 301);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(54, 20);
            this.lblMenuPrice.TabIndex = 20;
            this.lblMenuPrice.Text = "Price:";
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuName.Location = new System.Drawing.Point(12, 253);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(60, 20);
            this.lblMenuName.TabIndex = 19;
            this.lblMenuName.Text = "Name:";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(12, 205);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(85, 20);
            this.lblMenu.TabIndex = 18;
            this.lblMenu.Text = "Menu No:";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTableNo.Location = new System.Drawing.Point(12, 159);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(85, 20);
            this.lblTableNo.TabIndex = 17;
            this.lblTableNo.Text = "Table No:";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(415, 284);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(106, 58);
            this.btnConfirmOrder.TabIndex = 27;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnBackKitchen
            // 
            this.btnBackKitchen.Location = new System.Drawing.Point(12, 12);
            this.btnBackKitchen.Name = "btnBackKitchen";
            this.btnBackKitchen.Size = new System.Drawing.Size(56, 44);
            this.btnBackKitchen.TabIndex = 48;
            this.btnBackKitchen.Text = "Back";
            this.btnBackKitchen.UseVisualStyleBackColor = true;
            this.btnBackKitchen.Click += new System.EventHandler(this.btnBackKitchen_Click);
            // 
            // OrderConfirmationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 621);
            this.Controls.Add(this.btnBackKitchen);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.txtIdOrder);
            this.Controls.Add(this.lblIdOrder);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.txtMenuNo);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.lblMenuPrice);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.listOrder);
            this.DoubleBuffered = true;
            this.Name = "OrderConfirmationScreen";
            this.Text = "OrderConfirmationScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listOrder;
        private System.Windows.Forms.ColumnHeader IDaddisyon;
        private System.Windows.Forms.ColumnHeader TableNo;
        private System.Windows.Forms.ColumnHeader SaleMenuNo;
        private System.Windows.Forms.ColumnHeader SaleMenuName;
        private System.Windows.Forms.ColumnHeader SaleMenuPrice;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.TextBox txtIdOrder;
        private System.Windows.Forms.Label lblIdOrder;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtMenuNo;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnBackKitchen;
    }
}