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
using v1.ProductRepository;

namespace v1
{
    public partial class fAdCPU : Form
    {
        IProductRepository productRepository = new ProductRepositoryForAdmin();
        IUserAction userAction = new UserAction();

        public fAdCPU()
        {
            InitializeComponent();
            LoadData();
        }

        private IAdminAction GetUserAction() => this.userAction.AdminAction();

        private void LoadData() => SystemAction.LoadProducts(this.Text, tBProductID, tBProductName, tBTypeOfProduct, tBBrand,
            dTDateOfManufacture, tBQuaranty, tBRemainingQuantity, tBPrice, dGVProducts, productRepository);

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SystemAction.GetDataFromControls(out string productID, out string productName, out string type, out string brand, out string manufracturingDate,
                out int quaranty, out int remainingQuantity, out int productPrice, tBProductID, tBProductName, tBTypeOfProduct, tBBrand, dTDateOfManufacture,
                tBQuaranty, tBRemainingQuantity, tBPrice);
            var message = GetUserAction().AddProduct(productID, productName, type, brand, manufracturingDate, quaranty, remainingQuantity, productPrice) ?
                "Thêm sản phẩm thành công" : "Mã sản phẩm đã tồn tại!";
            MessageBox.Show(message, "Thông báo");
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SystemAction.GetDataFromControls(out string productID, out _, out _, out _, out _,out _, out _, out _, 
                tBProductID, tBProductName, tBTypeOfProduct, tBBrand, dTDateOfManufacture,
                tBQuaranty, tBRemainingQuantity, tBPrice);
            var message = GetUserAction().DeleteProduct(productID) ? "Xoá sản phẩm thành công" : "Mã sản phẩm không tồn tại!";
            MessageBox.Show(message, "Thông báo");
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SystemAction.GetDataFromControls(out string productID, out string productName, out string type, out string brand, out string manufracturingDate,
               out int quaranty, out int remainingQuantity, out int productPrice, tBProductID, tBProductName, tBTypeOfProduct, tBBrand, dTDateOfManufacture,
               tBQuaranty, tBRemainingQuantity, tBPrice);
            var message = GetUserAction().UpdateProduct(productID, productName, type, brand, manufracturingDate, quaranty, remainingQuantity, productPrice) ?
               "Đã cập nhật sản phẩm thành công" : "Mã sản phẩm không tồn tại!";
            MessageBox.Show(message, "Thông báo");
            LoadData();
        }
    }
}
