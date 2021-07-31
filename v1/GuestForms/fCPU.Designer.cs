namespace v1
{
    partial class fCPU
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tBQuantity = new System.Windows.Forms.TextBox();
            this.lBPrice = new System.Windows.Forms.Label();
            this.lBQuantity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.dGVProducts = new System.Windows.Forms.DataGridView();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.lBProductName = new System.Windows.Forms.Label();
            this.tBProductName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddToFav = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Location = new System.Drawing.Point(57, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 1);
            this.panel4.TabIndex = 13;
            // 
            // tBQuantity
            // 
            this.tBQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.tBQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBQuantity.ForeColor = System.Drawing.Color.White;
            this.tBQuantity.Location = new System.Drawing.Point(57, 263);
            this.tBQuantity.Name = "tBQuantity";
            this.tBQuantity.Size = new System.Drawing.Size(240, 17);
            this.tBQuantity.TabIndex = 4;
            this.tBQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBQuantity_KeyPress);
            // 
            // lBPrice
            // 
            this.lBPrice.AutoSize = true;
            this.lBPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBPrice.ForeColor = System.Drawing.Color.White;
            this.lBPrice.Location = new System.Drawing.Point(21, 328);
            this.lBPrice.Name = "lBPrice";
            this.lBPrice.Size = new System.Drawing.Size(105, 19);
            this.lBPrice.TabIndex = 12;
            this.lBPrice.Text = "Giá sản phẩm:";
            // 
            // lBQuantity
            // 
            this.lBQuantity.AutoSize = true;
            this.lBQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBQuantity.ForeColor = System.Drawing.Color.White;
            this.lBQuantity.Location = new System.Drawing.Point(21, 241);
            this.lBQuantity.Name = "lBQuantity";
            this.lBQuantity.Size = new System.Drawing.Size(112, 19);
            this.lBQuantity.TabIndex = 5;
            this.lBQuantity.Text = "Nhập số lượng:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Location = new System.Drawing.Point(57, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 1);
            this.panel3.TabIndex = 6;
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelProducts.Controls.Add(this.dGVProducts);
            this.panelProducts.Location = new System.Drawing.Point(12, 12);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(814, 767);
            this.panelProducts.TabIndex = 25;
            // 
            // dGVProducts
            // 
            this.dGVProducts.AllowUserToAddRows = false;
            this.dGVProducts.AllowUserToDeleteRows = false;
            this.dGVProducts.AllowUserToOrderColumns = true;
            this.dGVProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dGVProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVProducts.Location = new System.Drawing.Point(0, 0);
            this.dGVProducts.Name = "dGVProducts";
            this.dGVProducts.ReadOnly = true;
            this.dGVProducts.Size = new System.Drawing.Size(814, 767);
            this.dGVProducts.TabIndex = 0;
            // 
            // tBPrice
            // 
            this.tBPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.tBPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPrice.ForeColor = System.Drawing.Color.White;
            this.tBPrice.Location = new System.Drawing.Point(57, 350);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.ReadOnly = true;
            this.tBPrice.Size = new System.Drawing.Size(270, 17);
            this.tBPrice.TabIndex = 11;
            this.tBPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBProductName
            // 
            this.lBProductName.AutoSize = true;
            this.lBProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBProductName.ForeColor = System.Drawing.Color.White;
            this.lBProductName.Location = new System.Drawing.Point(21, 160);
            this.lBProductName.Name = "lBProductName";
            this.lBProductName.Size = new System.Drawing.Size(107, 19);
            this.lBProductName.TabIndex = 8;
            this.lBProductName.Text = "Tên sản phẩm:";
            // 
            // tBProductName
            // 
            this.tBProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.tBProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBProductName.ForeColor = System.Drawing.Color.White;
            this.tBProductName.Location = new System.Drawing.Point(57, 182);
            this.tBProductName.Name = "tBProductName";
            this.tBProductName.ReadOnly = true;
            this.tBProductName.Size = new System.Drawing.Size(270, 17);
            this.tBProductName.TabIndex = 7;
            this.tBProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel7.Location = new System.Drawing.Point(57, 205);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 1);
            this.panel7.TabIndex = 9;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelDetails.Controls.Add(this.btnReset);
            this.panelDetails.Controls.Add(this.lBProductName);
            this.panelDetails.Controls.Add(this.panel4);
            this.panelDetails.Controls.Add(this.tBQuantity);
            this.panelDetails.Controls.Add(this.lBPrice);
            this.panelDetails.Controls.Add(this.lBQuantity);
            this.panelDetails.Controls.Add(this.tBPrice);
            this.panelDetails.Controls.Add(this.panel3);
            this.panelDetails.Controls.Add(this.btnAddToFav);
            this.panelDetails.Controls.Add(this.tBProductName);
            this.panelDetails.Controls.Add(this.panel7);
            this.panelDetails.Controls.Add(this.btnAddToCart);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetails.Location = new System.Drawing.Point(832, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(350, 791);
            this.panelDetails.TabIndex = 24;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Silver;
            this.btnReset.Image = global::v1.Properties.Resources.icons8_reset_24__1_;
            this.btnReset.Location = new System.Drawing.Point(303, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(24, 24);
            this.btnReset.TabIndex = 14;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddToFav
            // 
            this.btnAddToFav.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToFav.FlatAppearance.BorderSize = 0;
            this.btnAddToFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToFav.ForeColor = System.Drawing.Color.Silver;
            this.btnAddToFav.Image = global::v1.Properties.Resources.plus;
            this.btnAddToFav.Location = new System.Drawing.Point(25, 431);
            this.btnAddToFav.Name = "btnAddToFav";
            this.btnAddToFav.Size = new System.Drawing.Size(109, 93);
            this.btnAddToFav.TabIndex = 10;
            this.btnAddToFav.Text = "Thích";
            this.btnAddToFav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToFav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddToFav.UseVisualStyleBackColor = false;
            this.btnAddToFav.Click += new System.EventHandler(this.btnAddToFav_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Silver;
            this.btnAddToCart.Image = global::v1.Properties.Resources.basket;
            this.btnAddToCart.Location = new System.Drawing.Point(218, 431);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(109, 113);
            this.btnAddToCart.TabIndex = 10;
            this.btnAddToCart.Text = "Thêm vào giỏ hàng";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // fCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1182, 791);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fCPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU";
            this.panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tBQuantity;
        private System.Windows.Forms.Label lBPrice;
        private System.Windows.Forms.Label lBQuantity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddToFav;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.DataGridView dGVProducts;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lBProductName;
        private System.Windows.Forms.TextBox tBProductName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panelDetails;
    }
}

