namespace v1.AdminForms
{
    partial class fAdminDetailOrder
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lBTitle = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.dGVCart = new System.Windows.Forms.DataGridView();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCart)).BeginInit();
            this.panelFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lBTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1098, 87);
            this.panelTitle.TabIndex = 1;
            // 
            // lBTitle
            // 
            this.lBTitle.AutoSize = true;
            this.lBTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBTitle.Location = new System.Drawing.Point(372, 33);
            this.lBTitle.Name = "lBTitle";
            this.lBTitle.Size = new System.Drawing.Size(304, 32);
            this.lBTitle.TabIndex = 0;
            this.lBTitle.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.dGVCart);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProducts.Location = new System.Drawing.Point(0, 87);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(907, 643);
            this.panelProducts.TabIndex = 2;
            // 
            // dGVCart
            // 
            this.dGVCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.dGVCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVCart.Location = new System.Drawing.Point(0, 0);
            this.dGVCart.Name = "dGVCart";
            this.dGVCart.Size = new System.Drawing.Size(907, 643);
            this.dGVCart.TabIndex = 0;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Controls.Add(this.btnBack);
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFunctions.Location = new System.Drawing.Point(913, 87);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(185, 643);
            this.panelFunctions.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::v1.Properties.Resources._return;
            this.btnBack.Location = new System.Drawing.Point(38, 265);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(108, 113);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Trở về";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fAdminDetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1098, 730);
            this.Controls.Add(this.panelFunctions);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdminDetailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdminDetailOrder";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCart)).EndInit();
            this.panelFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lBTitle;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.DataGridView dGVCart;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Button btnBack;
    }
}