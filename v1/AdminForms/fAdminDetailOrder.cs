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
using v1.Repositories.CartRepository;

namespace v1.AdminForms
{
    public partial class fAdminDetailOrder : Form
    {
        ICartRepository cartRepository = new CartRepository();
        public fAdminDetailOrder(string billID)
        {
            InitializeComponent();
            SystemAction.LoadCartDetail(dGVCart, cartRepository, billID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
