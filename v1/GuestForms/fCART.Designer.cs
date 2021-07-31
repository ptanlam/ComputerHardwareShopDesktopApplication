namespace v1.GuestForms
{
    partial class fCART
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
            this.panelUserCart = new System.Windows.Forms.Panel();
            this.lBUserCart = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.dGVCart = new System.Windows.Forms.DataGridView();
            this.panelCartFunctions = new System.Windows.Forms.Panel();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelUserCart.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCart)).BeginInit();
            this.panelCartFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserCart
            // 
            this.panelUserCart.Controls.Add(this.lBUserCart);
            this.panelUserCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserCart.Location = new System.Drawing.Point(0, 0);
            this.panelUserCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUserCart.Name = "panelUserCart";
            this.panelUserCart.Size = new System.Drawing.Size(1924, 158);
            this.panelUserCart.TabIndex = 11;
            // 
            // lBUserCart
            // 
            this.lBUserCart.AutoSize = true;
            this.lBUserCart.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBUserCart.ForeColor = System.Drawing.Color.White;
            this.lBUserCart.Location = new System.Drawing.Point(34, 48);
            this.lBUserCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBUserCart.Name = "lBUserCart";
            this.lBUserCart.Size = new System.Drawing.Size(697, 81);
            this.lBUserCart.TabIndex = 9;
            this.lBUserCart.Text = "Danh sách sản phẩm:";
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.Controls.Add(this.dGVCart);
            this.panelProduct.Location = new System.Drawing.Point(18, 168);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1578, 863);
            this.panelProduct.TabIndex = 12;
            // 
            // dGVCart
            // 
            this.dGVCart.AllowUserToAddRows = false;
            this.dGVCart.AllowUserToDeleteRows = false;
            this.dGVCart.AllowUserToOrderColumns = true;
            this.dGVCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dGVCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVCart.ColumnHeadersHeight = 29;
            this.dGVCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVCart.Location = new System.Drawing.Point(0, 0);
            this.dGVCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGVCart.Name = "dGVCart";
            this.dGVCart.ReadOnly = true;
            this.dGVCart.RowHeadersWidth = 51;
            this.dGVCart.Size = new System.Drawing.Size(1578, 863);
            this.dGVCart.TabIndex = 1;
            // 
            // panelCartFunctions
            // 
            this.panelCartFunctions.Controls.Add(this.btnDeleteAll);
            this.panelCartFunctions.Controls.Add(this.btnRemoveItem);
            this.panelCartFunctions.Controls.Add(this.btnConfirm);
            this.panelCartFunctions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCartFunctions.Location = new System.Drawing.Point(1604, 158);
            this.panelCartFunctions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCartFunctions.Name = "panelCartFunctions";
            this.panelCartFunctions.Size = new System.Drawing.Size(320, 891);
            this.panelCartFunctions.TabIndex = 13;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Silver;
            this.btnDeleteAll.Image = global::v1.Properties.Resources.trash;
            this.btnDeleteAll.Location = new System.Drawing.Point(68, 289);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(188, 183);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "Xoá tất cả";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Silver;
            this.btnRemoveItem.Image = global::v1.Properties.Resources.cancel;
            this.btnRemoveItem.Location = new System.Drawing.Point(68, 105);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(188, 175);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "Xoá sản phẩm";
            this.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Silver;
            this.btnConfirm.Image = global::v1.Properties.Resources.accept;
            this.btnConfirm.Location = new System.Drawing.Point(68, 482);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(188, 200);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Xác nhận mua hàng";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // fCART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.panelCartFunctions);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelUserCart);
            this.Name = "fCART";
            this.Text = "Giỏ hàng";
            this.panelUserCart.ResumeLayout(false);
            this.panelUserCart.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCart)).EndInit();
            this.panelCartFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserCart;
        private System.Windows.Forms.Label lBUserCart;
        private System.Windows.Forms.Panel panelProduct;
        public System.Windows.Forms.DataGridView dGVCart;
        private System.Windows.Forms.Panel panelCartFunctions;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnConfirm;
    }
}