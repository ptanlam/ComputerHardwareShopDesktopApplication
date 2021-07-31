namespace v1.GuestForms
{
    partial class fWISHLIST
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
            this.panelProduct = new System.Windows.Forms.Panel();
            this.dGVFav = new System.Windows.Forms.DataGridView();
            this.panelUserCart = new System.Windows.Forms.Panel();
            this.lBUserCart = new System.Windows.Forms.Label();
            this.panelCartFunctions = new System.Windows.Forms.Panel();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddAllToCart = new System.Windows.Forms.Button();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFav)).BeginInit();
            this.panelUserCart.SuspendLayout();
            this.panelCartFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.Controls.Add(this.dGVFav);
            this.panelProduct.Location = new System.Drawing.Point(9, 135);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1029, 538);
            this.panelProduct.TabIndex = 15;
            // 
            // dGVFav
            // 
            this.dGVFav.AllowUserToAddRows = false;
            this.dGVFav.AllowUserToDeleteRows = false;
            this.dGVFav.AllowUserToOrderColumns = true;
            this.dGVFav.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVFav.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dGVFav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVFav.ColumnHeadersHeight = 34;
            this.dGVFav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVFav.Location = new System.Drawing.Point(0, 0);
            this.dGVFav.Name = "dGVFav";
            this.dGVFav.ReadOnly = true;
            this.dGVFav.RowHeadersWidth = 62;
            this.dGVFav.Size = new System.Drawing.Size(1029, 538);
            this.dGVFav.TabIndex = 1;
            // 
            // panelUserCart
            // 
            this.panelUserCart.Controls.Add(this.lBUserCart);
            this.panelUserCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserCart.Location = new System.Drawing.Point(0, 0);
            this.panelUserCart.Name = "panelUserCart";
            this.panelUserCart.Size = new System.Drawing.Size(1283, 123);
            this.panelUserCart.TabIndex = 16;
            // 
            // lBUserCart
            // 
            this.lBUserCart.AutoSize = true;
            this.lBUserCart.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBUserCart.ForeColor = System.Drawing.Color.White;
            this.lBUserCart.Location = new System.Drawing.Point(23, 31);
            this.lBUserCart.Name = "lBUserCart";
            this.lBUserCart.Size = new System.Drawing.Size(464, 55);
            this.lBUserCart.TabIndex = 9;
            this.lBUserCart.Text = "Danh sách sản phẩm:";
            // 
            // panelCartFunctions
            // 
            this.panelCartFunctions.Controls.Add(this.btnDeleteAll);
            this.panelCartFunctions.Controls.Add(this.btnRemoveItem);
            this.panelCartFunctions.Controls.Add(this.btnAddAllToCart);
            this.panelCartFunctions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCartFunctions.Location = new System.Drawing.Point(1043, 123);
            this.panelCartFunctions.Name = "panelCartFunctions";
            this.panelCartFunctions.Size = new System.Drawing.Size(240, 559);
            this.panelCartFunctions.TabIndex = 17;
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
            this.btnDeleteAll.Location = new System.Drawing.Point(51, 236);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(141, 113);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "Xoá tất cả";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
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
            this.btnRemoveItem.Location = new System.Drawing.Point(51, 85);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(141, 113);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "Xoá sản phẩm";
            this.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddAllToCart
            // 
            this.btnAddAllToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAllToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAllToCart.FlatAppearance.BorderSize = 0;
            this.btnAddAllToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAllToCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllToCart.ForeColor = System.Drawing.Color.Silver;
            this.btnAddAllToCart.Image = global::v1.Properties.Resources.add;
            this.btnAddAllToCart.Location = new System.Drawing.Point(51, 392);
            this.btnAddAllToCart.Name = "btnAddAllToCart";
            this.btnAddAllToCart.Size = new System.Drawing.Size(141, 113);
            this.btnAddAllToCart.TabIndex = 11;
            this.btnAddAllToCart.Text = "Thêm tất cả vào giỏ hàng";
            this.btnAddAllToCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAllToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddAllToCart.UseVisualStyleBackColor = false;
            this.btnAddAllToCart.Click += new System.EventHandler(this.btnAddAllToCart_Click);
            // 
            // fWISHLIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.panelCartFunctions);
            this.Controls.Add(this.panelUserCart);
            this.Controls.Add(this.panelProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fWISHLIST";
            this.Text = "YÊU THÍCH";
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFav)).EndInit();
            this.panelUserCart.ResumeLayout(false);
            this.panelUserCart.PerformLayout();
            this.panelCartFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelProduct;
        public System.Windows.Forms.DataGridView dGVFav;
        private System.Windows.Forms.Panel panelUserCart;
        private System.Windows.Forms.Label lBUserCart;
        private System.Windows.Forms.Panel panelCartFunctions;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddAllToCart;
    }
}