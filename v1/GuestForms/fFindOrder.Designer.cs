namespace v1.GuestForms
{
    partial class fFindOrder
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
            this.lBProductName = new System.Windows.Forms.Label();
            this.tBGuestID = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lBProductName
            // 
            this.lBProductName.AutoSize = true;
            this.lBProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBProductName.ForeColor = System.Drawing.Color.White;
            this.lBProductName.Location = new System.Drawing.Point(281, 115);
            this.lBProductName.Name = "lBProductName";
            this.lBProductName.Size = new System.Drawing.Size(179, 19);
            this.lBProductName.TabIndex = 14;
            this.lBProductName.Text = "Nhập số CMND của bạn:";
            // 
            // tBGuestID
            // 
            this.tBGuestID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.tBGuestID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBGuestID.ForeColor = System.Drawing.Color.White;
            this.tBGuestID.Location = new System.Drawing.Point(317, 137);
            this.tBGuestID.Name = "tBGuestID";
            this.tBGuestID.Size = new System.Drawing.Size(456, 17);
            this.tBGuestID.TabIndex = 13;
            this.tBGuestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBGuestID.TextChanged += new System.EventHandler(this.tBGuestID_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel7.Location = new System.Drawing.Point(317, 160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 1);
            this.panel7.TabIndex = 15;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dGVOrders);
            this.panelContainer.Location = new System.Drawing.Point(81, 206);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(934, 463);
            this.panelContainer.TabIndex = 16;
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
            this.dGVOrders.ReadOnly = true;
            this.dGVOrders.Size = new System.Drawing.Size(934, 463);
            this.dGVOrders.TabIndex = 3;
            // 
            // fFindOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1098, 730);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lBProductName);
            this.Controls.Add(this.tBGuestID);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFindOrder";
            this.Text = "Tìm đơn hàng";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBProductName;
        private System.Windows.Forms.TextBox tBGuestID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dGVOrders;
    }
}