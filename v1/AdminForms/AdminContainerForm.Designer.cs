namespace v1.AdminForms
{
    partial class AdminContainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminContainerForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCase = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnHardDrive = new System.Windows.Forms.Button();
            this.btnMB = new System.Windows.Forms.Button();
            this.btnGPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lBTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnCase);
            this.panelMenu.Controls.Add(this.btnPSU);
            this.panelMenu.Controls.Add(this.btnHardDrive);
            this.panelMenu.Controls.Add(this.btnMB);
            this.panelMenu.Controls.Add(this.btnGPU);
            this.panelMenu.Controls.Add(this.btnRAM);
            this.panelMenu.Controls.Add(this.btnCPU);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 861);
            this.panelMenu.TabIndex = 6;
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.Image = global::v1.Properties.Resources.orders;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 500);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 60);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "  Đơn hàng";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 781);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 80);
            this.panel2.TabIndex = 7;
            // 
            // btnCase
            // 
            this.btnCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCase.FlatAppearance.BorderSize = 0;
            this.btnCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCase.Image = global::v1.Properties.Resources._case;
            this.btnCase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCase.Location = new System.Drawing.Point(0, 440);
            this.btnCase.Name = "btnCase";
            this.btnCase.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCase.Size = new System.Drawing.Size(220, 60);
            this.btnCase.TabIndex = 6;
            this.btnCase.Text = "  Case";
            this.btnCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCase.UseVisualStyleBackColor = true;
            // 
            // btnPSU
            // 
            this.btnPSU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPSU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPSU.FlatAppearance.BorderSize = 0;
            this.btnPSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSU.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPSU.Image = global::v1.Properties.Resources.psu;
            this.btnPSU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPSU.Location = new System.Drawing.Point(0, 380);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPSU.Size = new System.Drawing.Size(220, 60);
            this.btnPSU.TabIndex = 5;
            this.btnPSU.Text = "  PSU";
            this.btnPSU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPSU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPSU.UseVisualStyleBackColor = true;
            // 
            // btnHardDrive
            // 
            this.btnHardDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHardDrive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHardDrive.FlatAppearance.BorderSize = 0;
            this.btnHardDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardDrive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardDrive.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHardDrive.Image = global::v1.Properties.Resources.harddrive;
            this.btnHardDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHardDrive.Location = new System.Drawing.Point(0, 320);
            this.btnHardDrive.Name = "btnHardDrive";
            this.btnHardDrive.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHardDrive.Size = new System.Drawing.Size(220, 60);
            this.btnHardDrive.TabIndex = 4;
            this.btnHardDrive.Text = "  Hard Drive";
            this.btnHardDrive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHardDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHardDrive.UseVisualStyleBackColor = true;
            // 
            // btnMB
            // 
            this.btnMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMB.FlatAppearance.BorderSize = 0;
            this.btnMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMB.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMB.Image = global::v1.Properties.Resources.mainboard;
            this.btnMB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMB.Location = new System.Drawing.Point(0, 260);
            this.btnMB.Name = "btnMB";
            this.btnMB.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMB.Size = new System.Drawing.Size(220, 60);
            this.btnMB.TabIndex = 3;
            this.btnMB.Text = "  Mainboard";
            this.btnMB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMB.UseVisualStyleBackColor = true;
            // 
            // btnGPU
            // 
            this.btnGPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGPU.FlatAppearance.BorderSize = 0;
            this.btnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGPU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGPU.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGPU.Image = ((System.Drawing.Image)(resources.GetObject("btnGPU.Image")));
            this.btnGPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGPU.Location = new System.Drawing.Point(0, 200);
            this.btnGPU.Name = "btnGPU";
            this.btnGPU.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGPU.Size = new System.Drawing.Size(220, 60);
            this.btnGPU.TabIndex = 2;
            this.btnGPU.Text = "  GPU";
            this.btnGPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGPU.UseVisualStyleBackColor = true;
            // 
            // btnRAM
            // 
            this.btnRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRAM.FlatAppearance.BorderSize = 0;
            this.btnRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRAM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAM.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRAM.Image = global::v1.Properties.Resources.ram;
            this.btnRAM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRAM.Location = new System.Drawing.Point(0, 140);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRAM.Size = new System.Drawing.Size(220, 60);
            this.btnRAM.TabIndex = 1;
            this.btnRAM.Text = "  RAM";
            this.btnRAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRAM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRAM.UseVisualStyleBackColor = true;
            // 
            // btnCPU
            // 
            this.btnCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCPU.Image = global::v1.Properties.Resources.cpu;
            this.btnCPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPU.Location = new System.Drawing.Point(0, 80);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCPU.Size = new System.Drawing.Size(220, 60);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "  CPU";
            this.btnCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelTitleBar.Controls.Add(this.lBTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1214, 80);
            this.panelTitleBar.TabIndex = 7;
            // 
            // lBTitle
            // 
            this.lBTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBTitle.AutoSize = true;
            this.lBTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBTitle.ForeColor = System.Drawing.Color.White;
            this.lBTitle.Location = new System.Drawing.Point(521, 17);
            this.lBTitle.Name = "lBTitle";
            this.lBTitle.Size = new System.Drawing.Size(195, 36);
            this.lBTitle.TabIndex = 0;
            this.lBTitle.Text = "TÊN GÌ ĐÓ?";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(220, 80);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1214, 781);
            this.panelContainer.TabIndex = 9;
            // 
            // AdminContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1434, 861);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminContainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminContainerForm";
            this.Load += new System.EventHandler(this.AdminContainerForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnHardDrive;
        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Button btnGPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lBTitle;
        private System.Windows.Forms.Panel panelContainer;
    }
}