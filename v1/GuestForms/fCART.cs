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
using v1.Repositories.TempCartRepository;

namespace v1.GuestForms
{
    public partial class fCART : Form
    {
        ITempCartRepository tempCartRepository = new TempCartRepository();
        IUserAction userAction = new UserAction();

        public fCART()
        {
            InitializeComponent();
            LoadTempCart();
        }

        private void LoadTempCart() => SystemAction.LoadTempCart(dGVCart, tempCartRepository);

        private IGuestAction GetUserAction() => this.userAction.GuestAction();

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string message;
            if (int.Parse(dGVCart.RowCount.ToString()) != 0)
            {
                var productID = dGVCart.CurrentRow.Cells["productID"].Value.ToString();
                GetUserAction().RemoveProductFromTempCart(productID);
                LoadTempCart();
                message = "Xoá sán phẩm thành công";
            }
            else
            {
                message = "Giỏ hàng rỗng";
            }

            MessageBox.Show(message, "Thông báo");
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var productID = dGVCart.Rows.OfType<DataGridViewRow>()
                .Select(p => p.Cells["productID"].Value.ToString())
                .ToList();
            if (productID.Count == 0) MessageBox.Show("Giỏ hàng rỗng", "Thông báo");
            else
            {
                for (int i = 0; i < productID.Count; i++)
                {
                    GetUserAction().RemoveProductFromTempCart(productID[i]);
                }
                LoadTempCart();
                var message = "Xoá sán phẩm thành công";
                MessageBox.Show(message, "Thông báo");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dGVCart.Rows.Count == 0)
            {
                MessageBox.Show("Chưa thêm sản phẩm vào giỏ hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fGuestOrder guestOrder = new fGuestOrder();
                guestOrder.ShowDialog();
                this.Show();
                LoadTempCart();
            }
        }
    }
}
