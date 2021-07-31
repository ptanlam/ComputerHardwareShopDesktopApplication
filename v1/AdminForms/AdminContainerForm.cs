using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1.AdminForms
{
    public partial class AdminContainerForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activatedForm;

        public AdminContainerForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivatedButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisabledButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panel2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisabledButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(72, 84, 96);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activatedForm != null)
                activatedForm.Close();
            ActivatedButton(btnSender);
            activatedForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lBTitle.Text = childForm.Text;
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAdCPU(), sender);
        }

        private void AdminContainerForm_Load(object sender, EventArgs e)
        {
            btnCPU.PerformClick();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAdApproveOrders(), sender);
        }
    }
}
