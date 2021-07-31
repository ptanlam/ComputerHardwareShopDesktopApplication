using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1.Action;
using v1.Action.Guest;
using v1.Action.System;
using v1.Repositories;

namespace v1.GuestForms
{
    public partial class fFindOrder : Form
    {
        IOrdersRepository ordersRepository = new OrdersRepository();

        public fFindOrder()
        {
            InitializeComponent();
        }

        private void tBGuestID_TextChanged(object sender, EventArgs e)
        {
            SystemAction.LoadOrders(dGVOrders, ordersRepository, tBGuestID.Text.ToString());
        }
    }
}
