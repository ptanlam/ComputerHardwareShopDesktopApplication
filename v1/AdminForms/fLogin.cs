using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1.Action.System;
using v1.Repositories.AccountRepository;

namespace v1.AdminForms
{
    public partial class fLogin : Form
    {
        IAccountRepository accountRepository = new AccountRepository();
        public fLogin()
        {
            InitializeComponent();
        }

        private void Authenticate()
        {
            if (SystemAction.IsAuthenticated(tBUsername, tBPassword, accountRepository))
            {
                AdminContainerForm adminForm = new AdminContainerForm();
                this.Hide();
                adminForm.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
        }

        private void tBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Authenticate();
            }
        }
    }
}
