namespace v1
{
    partial class WelcomeForm
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
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.Bisque;
            this.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuest.FlatAppearance.BorderSize = 0;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.Black;
            this.btnGuest.Image = global::v1.Properties.Resources.guest;
            this.btnGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuest.Location = new System.Drawing.Point(262, 140);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(351, 131);
            this.btnGuest.TabIndex = 2;
            this.btnGuest.Text = "Khách Hàng";
            this.btnGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Image = global::v1.Properties.Resources.staff;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(262, 308);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(351, 131);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Nhân viên";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::v1.Properties.Resources._2738;
            this.ClientSize = new System.Drawing.Size(876, 578);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnAdmin;
    }
}