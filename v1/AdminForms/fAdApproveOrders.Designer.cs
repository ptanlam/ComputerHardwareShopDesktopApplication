namespace v1.AdminForms
{
    partial class fAdApproveOrders
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
            this.panelFuntions = new System.Windows.Forms.Panel();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnShowCart = new System.Windows.Forms.Button();
            this.panelGuestInfo = new System.Windows.Forms.Panel();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.panelFuntions.SuspendLayout();
            this.panelGuestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFuntions
            // 
            this.panelFuntions.Controls.Add(this.btnComplete);
            this.panelFuntions.Controls.Add(this.btnConfirmOrder);
            this.panelFuntions.Controls.Add(this.btnShowCart);
            this.panelFuntions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFuntions.Location = new System.Drawing.Point(0, 481);
            this.panelFuntions.Name = "panelFuntions";
            this.panelFuntions.Size = new System.Drawing.Size(1098, 111);
            this.panelFuntions.TabIndex = 5;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.LightGray;
            this.btnComplete.Image = global::v1.Properties.Resources.completed;
            this.btnComplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplete.Location = new System.Drawing.Point(771, 20);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(148, 79);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "  Đã chuyển";
            this.btnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnConfirmOrder.Image = global::v1.Properties.Resources.packaged;
            this.btnConfirmOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmOrder.Location = new System.Drawing.Point(488, 20);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(148, 79);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Text = "  Duyệt đơn";
            this.btnConfirmOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnShowCart
            // 
            this.btnShowCart.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowCart.FlatAppearance.BorderSize = 0;
            this.btnShowCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCart.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowCart.Image = global::v1.Properties.Resources.Details;
            this.btnShowCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCart.Location = new System.Drawing.Point(191, 20);
            this.btnShowCart.Name = "btnShowCart";
            this.btnShowCart.Size = new System.Drawing.Size(192, 79);
            this.btnShowCart.TabIndex = 2;
            this.btnShowCart.Text = "  Chi tiết đơn hàng";
            this.btnShowCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCart.UseVisualStyleBackColor = false;
            this.btnShowCart.Click += new System.EventHandler(this.btnShowCart_Click);
            // 
            // panelGuestInfo
            // 
            this.panelGuestInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGuestInfo.Controls.Add(this.dGVOrders);
            this.panelGuestInfo.Location = new System.Drawing.Point(12, 12);
            this.panelGuestInfo.Name = "panelGuestInfo";
            this.panelGuestInfo.Size = new System.Drawing.Size(1074, 463);
            this.panelGuestInfo.TabIndex = 6;
            // 
            // dGVOrders
            // 
            this.dGVOrders.AllowUserToAddRows = false;
            this.dGVOrders.AllowUserToDeleteRows = false;
            this.dGVOrders.AllowUserToOrderColumns = true;
            this.dGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dGVOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVOrders.Location = new System.Drawing.Point(0, 0);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.Size = new System.Drawing.Size(1074, 463);
            this.dGVOrders.TabIndex = 2;
            // 
            // fAdApproveOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1098, 592);
            this.Controls.Add(this.panelGuestInfo);
            this.Controls.Add(this.panelFuntions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdApproveOrders";
            this.Text = "Đơn hàng";
            this.panelFuntions.ResumeLayout(false);
            this.panelGuestInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFuntions;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnShowCart;
        private System.Windows.Forms.Panel panelGuestInfo;
        public System.Windows.Forms.DataGridView dGVOrders;
    }
}