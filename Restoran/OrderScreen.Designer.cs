namespace Restoran
{
    partial class OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.txtMenuNo = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.listOrder = new System.Windows.Forms.ListView();
            this.IDaddisyon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleMenuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleMenuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleMenuPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMenu = new System.Windows.Forms.ListView();
            this.MenuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.lblIdOrder = new System.Windows.Forms.Label();
            this.txtIdOrder = new System.Windows.Forms.TextBox();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.btnBackWaiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTableNo.Location = new System.Drawing.Point(12, 169);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(85, 20);
            this.lblTableNo.TabIndex = 0;
            this.lblTableNo.Text = "Table No:";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(12, 215);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(85, 20);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu No:";
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuName.Location = new System.Drawing.Point(12, 263);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(60, 20);
            this.lblMenuName.TabIndex = 3;
            this.lblMenuName.Text = "Name:";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuPrice.Location = new System.Drawing.Point(12, 311);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(54, 20);
            this.lblMenuPrice.TabIndex = 4;
            this.lblMenuPrice.Text = "Price:";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(103, 169);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(65, 20);
            this.txtTableNo.TabIndex = 5;
            // 
            // txtMenuNo
            // 
            this.txtMenuNo.Location = new System.Drawing.Point(103, 215);
            this.txtMenuNo.Name = "txtMenuNo";
            this.txtMenuNo.ReadOnly = true;
            this.txtMenuNo.Size = new System.Drawing.Size(65, 20);
            this.txtMenuNo.TabIndex = 6;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(103, 263);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.ReadOnly = true;
            this.txtMenuName.Size = new System.Drawing.Size(92, 20);
            this.txtMenuName.TabIndex = 7;
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(103, 311);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.ReadOnly = true;
            this.txtMenuPrice.Size = new System.Drawing.Size(65, 20);
            this.txtMenuPrice.TabIndex = 8;
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
            this.listOrder.Location = new System.Drawing.Point(16, 346);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(538, 165);
            this.listOrder.TabIndex = 9;
            this.listOrder.UseCompatibleStateImageBehavior = false;
            this.listOrder.View = System.Windows.Forms.View.Details;
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
            // listMenu
            // 
            this.listMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuNo,
            this.MenuName,
            this.MenuPrice});
            this.listMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listMenu.HideSelection = false;
            this.listMenu.Location = new System.Drawing.Point(585, 114);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(244, 397);
            this.listMenu.TabIndex = 10;
            this.listMenu.UseCompatibleStateImageBehavior = false;
            this.listMenu.View = System.Windows.Forms.View.Details;
            this.listMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listMenuView_MouseDoubleClick);
            // 
            // MenuNo
            // 
            this.MenuNo.Text = "Menu No";
            this.MenuNo.Width = 57;
            // 
            // MenuName
            // 
            this.MenuName.Text = "Menu Name";
            this.MenuName.Width = 92;
            // 
            // MenuPrice
            // 
            this.MenuPrice.Text = "Menu Price";
            this.MenuPrice.Width = 91;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(336, 282);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(106, 58);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.Location = new System.Drawing.Point(723, 84);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(106, 24);
            this.btnShowMenu.TabIndex = 12;
            this.btnShowMenu.Text = "Show Menu";
            this.btnShowMenu.UseVisualStyleBackColor = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // lblIdOrder
            // 
            this.lblIdOrder.AutoSize = true;
            this.lblIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdOrder.Location = new System.Drawing.Point(12, 131);
            this.lblIdOrder.Name = "lblIdOrder";
            this.lblIdOrder.Size = new System.Drawing.Size(33, 20);
            this.lblIdOrder.TabIndex = 13;
            this.lblIdOrder.Text = "ID:";
            // 
            // txtIdOrder
            // 
            this.txtIdOrder.Location = new System.Drawing.Point(51, 131);
            this.txtIdOrder.Name = "txtIdOrder";
            this.txtIdOrder.Size = new System.Drawing.Size(46, 20);
            this.txtIdOrder.TabIndex = 14;
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Location = new System.Drawing.Point(448, 282);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(106, 58);
            this.btnShowOrder.TabIndex = 15;
            this.btnShowOrder.Text = "Show Order(s)";
            this.btnShowOrder.UseVisualStyleBackColor = true;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // btnBackWaiter
            // 
            this.btnBackWaiter.Location = new System.Drawing.Point(12, 12);
            this.btnBackWaiter.Name = "btnBackWaiter";
            this.btnBackWaiter.Size = new System.Drawing.Size(56, 44);
            this.btnBackWaiter.TabIndex = 48;
            this.btnBackWaiter.Text = "Back";
            this.btnBackWaiter.UseVisualStyleBackColor = true;
            this.btnBackWaiter.Click += new System.EventHandler(this.btnBackWaiter_Click);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 618);
            this.Controls.Add(this.btnBackWaiter);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.txtIdOrder);
            this.Controls.Add(this.lblIdOrder);
            this.Controls.Add(this.btnShowMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.txtMenuNo);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.lblMenuPrice);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTableNo);
            this.DoubleBuffered = true;
            this.Name = "OrderScreen";
            this.Text = "OrderScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.TextBox txtMenuNo;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.ListView listOrder;
        private System.Windows.Forms.ColumnHeader IDaddisyon;
        private System.Windows.Forms.ColumnHeader TableNo;
        private System.Windows.Forms.ColumnHeader SaleMenuNo;
        private System.Windows.Forms.ColumnHeader SaleMenuName;
        private System.Windows.Forms.ListView listMenu;
        private System.Windows.Forms.ColumnHeader MenuNo;
        private System.Windows.Forms.ColumnHeader MenuName;
        private System.Windows.Forms.ColumnHeader MenuPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.ColumnHeader SaleMenuPrice;
        private System.Windows.Forms.Label lblIdOrder;
        private System.Windows.Forms.TextBox txtIdOrder;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.Button btnBackWaiter;
    }
}