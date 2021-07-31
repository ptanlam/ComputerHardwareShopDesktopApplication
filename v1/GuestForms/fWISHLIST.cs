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
using v1.Repositories.WishListRepository;

namespace v1.GuestForms
{
    public partial class fWISHLIST : Form
    {
        IWishListRepository wishListRepository = new WishListRepository();
        IUserAction userAction = new UserAction();

        public fWISHLIST()
        {
            InitializeComponent();
            LoadWishList();
        }
        private void LoadWishList() => SystemAction.LoadWishList(dGVFav, wishListRepository);

        private IGuestAction GetUserAction() => this.userAction.GuestAction();

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string message;
            if (int.Parse(dGVFav.RowCount.ToString()) != 0)
            {
                var productID = dGVFav.CurrentRow.Cells["productID"].Value.ToString();
                GetUserAction().RemoveProductFromWishList(productID);
                LoadWishList();
                message = "Xoá sán phẩm thành công";
            }
            else
            {
                message = "Giỏ hàng rỗng";
            }
            MessageBox.Show(message, "Thông báo");
        }

        private void btnAddAllToCart_Click(object sender, EventArgs e)
        {
            var productID = dGVFav.Rows.OfType<DataGridViewRow>()
               .Select(p => p.Cells["productID"].Value.ToString())
               .ToList();
            if (productID.Count == 0) MessageBox.Show("Giỏ hàng rỗng", "Thông báo");
            else
            {
                for (int i = 0; i < productID.Count; i++)
                {
                    GetUserAction().AddToTempCart(productID[i]);
                }
                MessageBox.Show("Đã thêm tất cả vào giỏ hàng thành công!", "Thông báo");
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            var productID = dGVFav.Rows.OfType<DataGridViewRow>()
                .Select(p => p.Cells["productID"].Value.ToString())
                .ToList();
            if (productID.Count == 0) MessageBox.Show("Giỏ hàng rỗng", "Thông báo");
            else
            {
                for (int i = 0; i < productID.Count; i++)
                {
                    GetUserAction().RemoveProductFromWishList(productID[i]);
                }
                LoadWishList();
                var message = "Xoá sán phẩm thành công";
                MessageBox.Show(message, "Thông báo");
            }
        }
    }
}
