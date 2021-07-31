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
using v1.Action.Admin;
using v1.Action.System;
using v1.Repositories;

namespace v1.AdminForms
{
    public partial class fAdApproveOrders : Form
    {
        IOrdersRepository ordersRepository = new OrdersRepository();
        IUserAction userAction = new UserAction();

        public fAdApproveOrders()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders() => SystemAction.LoadOrders(dGVOrders, ordersRepository);

        private IAdminAction GetUserAction() => this.userAction.AdminAction();

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            if (dGVOrders.Rows.Count != 0)
            {
                fAdminDetailOrder details = new fAdminDetailOrder(dGVOrders.CurrentRow.Cells["billID"].Value.ToString());
                details.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            string message;
            if (!GetUserAction().ApproveOrder(dGVOrders.CurrentRow.Cells["billID"].Value.ToString()))
                message = "Không đủ số lượng hàng hoá trong kho!";
            else message = "Đã duyệt đơn hàng";
            MessageBox.Show(message, "Thông báo");
            LoadOrders();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string message;
            if (GetUserAction().CompleteOrder(dGVOrders.CurrentRow.Cells["billID"].Value.ToString()))
                message = "Đơn hàng đã được hoàn tất!";
            else message = "Đơn hàng chưa được duyệt!";
            MessageBox.Show(message, "Thông báo");
            LoadOrders();
        }
    }
}
