using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1.AdminForms;

namespace v1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            GuestContainerForm guestForm = new GuestContainerForm();
            this.Hide();
            guestForm.ShowDialog();
            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fLogin adminForm = new fLogin();
            this.Hide();
            adminForm.ShowDialog();
            this.Show();
        }
    }
}
