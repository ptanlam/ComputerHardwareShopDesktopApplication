namespace v1.AdminForms
{
    partial class fLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.lBPassword = new System.Windows.Forms.Label();
            this.lBUsername = new System.Windows.Forms.Label();
            this.panelShopName = new System.Windows.Forms.Panel();
            this.lBShopName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelShopName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tBPassword);
            this.panel2.Controls.Add(this.tBUsername);
            this.panel2.Controls.Add(this.lBPassword);
            this.panel2.Controls.Add(this.lBUsername);
            this.panel2.Location = new System.Drawing.Point(12, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 301);
            this.panel2.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(227, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(68, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(68, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 1);
            this.panel3.TabIndex = 2;
            // 
            // tBPassword
            // 
            this.tBPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.Location = new System.Drawing.Point(69, 174);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(262, 19);
            this.tBPassword.TabIndex = 2;
            this.tBPassword.UseSystemPasswordChar = true;
            this.tBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_KeyPress);
            // 
            // tBUsername
            // 
            this.tBUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tBUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsername.Location = new System.Drawing.Point(69, 68);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(262, 19);
            this.tBUsername.TabIndex = 1;
            // 
            // lBPassword
            // 
            this.lBPassword.AutoSize = true;
            this.lBPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBPassword.Location = new System.Drawing.Point(23, 149);
            this.lBPassword.Name = "lBPassword";
            this.lBPassword.Size = new System.Drawing.Size(95, 22);
            this.lBPassword.TabIndex = 0;
            this.lBPassword.Text = "Mật khẩu:";
            // 
            // lBUsername
            // 
            this.lBUsername.AutoSize = true;
            this.lBUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBUsername.Location = new System.Drawing.Point(23, 43);
            this.lBUsername.Name = "lBUsername";
            this.lBUsername.Size = new System.Drawing.Size(137, 22);
            this.lBUsername.TabIndex = 0;
            this.lBUsername.Text = "Tên đăng nhập:";
            // 
            // panelShopName
            // 
            this.panelShopName.BackgroundImage = global::v1.Properties.Resources._3359764;
            this.panelShopName.Controls.Add(this.lBShopName);
            this.panelShopName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShopName.Location = new System.Drawing.Point(0, 0);
            this.panelShopName.Name = "panelShopName";
            this.panelShopName.Size = new System.Drawing.Size(384, 151);
            this.panelShopName.TabIndex = 9;
            // 
            // lBShopName
            // 
            this.lBShopName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBShopName.AutoSize = true;
            this.lBShopName.BackColor = System.Drawing.Color.Transparent;
            this.lBShopName.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBShopName.ForeColor = System.Drawing.SystemColors.Window;
            this.lBShopName.Location = new System.Drawing.Point(46, 49);
            this.lBShopName.Name = "lBShopName";
            this.lBShopName.Size = new System.Drawing.Size(271, 55);
            this.lBShopName.TabIndex = 0;
            this.lBShopName.Text = "Tên .............";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::v1.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(27, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::v1.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panelShopName);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelShopName.ResumeLayout(false);
            this.panelShopName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tBPassword;
        public System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Label lBPassword;
        private System.Windows.Forms.Label lBUsername;
        private System.Windows.Forms.Panel panelShopName;
        private System.Windows.Forms.Label lBShopName;
    }
}