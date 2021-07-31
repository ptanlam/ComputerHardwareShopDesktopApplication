using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1.GuestForms;

namespace v1
{
    public partial class GuestContainerForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activatedForm;
        private int imgNumber = 1;

        public GuestContainerForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }

        private void LoadNextImage()
        {
            if (imgNumber == 11)
            {
                imgNumber = 1;
            }
            pBSlideShow.ImageLocation = string.Format(@"..\..\..\images\{0}.jpg", imgNumber);
            imgNumber++;
        }

        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
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
                    btnCloseChildForm.Visible = true;
                    panelContact.Visible = false;
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

        private void Reset()
        {
            DisabledButton();
            lBTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(72, 84, 96);
            panelLogo.BackColor = Color.FromArgb(30, 39, 46);
            panel2.BackColor = Color.FromArgb(30, 39, 46);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            panelContact.Visible = true;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activatedForm != null)
                activatedForm.Close();
            Reset();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCPU(), sender);
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCART(), sender);
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fWISHLIST(), sender);
        }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fFindOrder(), sender);
        }
    }
}
