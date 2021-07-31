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
using v1.DAL;
using v1.UIFormat;

namespace v1
{
    public partial class fCPU : Form
    {
        IProductRepository productRepository = new ProductRepositoryForGuest();
        IUserAction userAction = new UserAction();

        public fCPU()
        {
            InitializeComponent();
            SystemAction.LoadProducts(this.Text, tBProductName, tBQuantity, tBPrice, dGVProducts, productRepository);
        }

        private IGuestAction GetUserAction() => this.userAction.GuestAction(); 

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            SystemAction.GetDataFromControls(out string productID, out string productName, out int productPrice, out int quantity,
                tBProductName, tBQuantity, tBPrice, dGVProducts);
            GetUserAction().AddToTempCart(productID, productName, productPrice, quantity);
            MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công", "Thông báo");
        }     

        private void btnAddToFav_Click(object sender, EventArgs e)
        {
            SystemAction.GetDataFromControls(out string productID, out string productName, out int productPrice, out _,
                tBProductName, tBQuantity, tBPrice, dGVProducts);
            string message = GetUserAction().AddToFav(productID, productName, productPrice) ? "Thêm sản phẩm vào mục yêu thích thành công" :
                "Bạn đã thêm sản phẩm này vào mục yêu thích rồi!";
            MessageBox.Show(message, "Thông báo");
        }

        private void tBQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GetUserAction().CheckNumberValidation(e.KeyChar)) e.Handled = true;
            else
            {
                int total = GetUserAction().CalculatePrice(int.Parse(tBPrice.Text), tBQuantity.Text == "" ? 1 : int.Parse(tBQuantity.Text));
                tBPrice.Text = total.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SystemAction.ResetPrice(tBPrice, tBQuantity, dGVProducts);
        }
    }
}
