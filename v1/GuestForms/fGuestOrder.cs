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
    public partial class fGuestOrder : Form
    {
        ITempCartRepository tempCartRepository = new TempCartRepository();
        IUserAction userAction = new UserAction();

        public fGuestOrder()
        {
            InitializeComponent();
            LoadTempCart();
        }

        private void LoadTempCart() => SystemAction.LoadTempCart(dGVCart, tempCartRepository, tBQuantity, tBTotalPrice);

        private IGuestAction GetUserAction() => this.userAction.GuestAction();

        private void ClearControlsData()
        {
            tBGuestName.Text = "";
            tBGuestID.Text = "";
            tBGuestAddress.Text = "";
            tBGuestPhoneNum.Text = "";
            tBQuantity.Text = "";
            tBTotalPrice.Text = "";
            dGVCart.Visible = false;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (tBGuestName.Text != "" && tBGuestID.Text != "" && tBGuestAddress.Text != "" && tBGuestPhoneNum.Text != "")
            {
                SystemAction.GetDataFromControls(out List<string> cart, out string guestID, out string guestName,
                out string guestAddress, out string phone, out int quantity, out int total, dGVCart, tBGuestID,
                tBGuestName, tBGuestAddress, tBGuestPhoneNum, tBQuantity, tBTotalPrice);
                GetUserAction().AddToRealCart(cart, guestID, guestName, guestAddress, phone, quantity, total);
                ClearControlsData();
                MessageBox.Show("Đã đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (tBGuestName.Text != "" || tBGuestID.Text != "" || tBGuestAddress.Text != "" || tBGuestPhoneNum.Text != "")
            {
                var DR = MessageBox.Show("Thoát sẽ bị mất thông tin bạn đã điền. \nBạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    this.Close();
                }
            }    
            else this.Close();
        }
    }
}
