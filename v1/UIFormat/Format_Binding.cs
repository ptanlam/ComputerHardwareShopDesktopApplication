using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1.UIFormat
{
    class Format_Binding
    {
        private static void FormatHeaderDGV(DataGridView dGV, string[] headers)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                dGV.Columns[i].AutoSizeMode = (i == headers.Length - 1) ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells;
                dGV.Columns[i].HeaderText = headers[i];
            }
        }

        public static void FormatGuestProductDGV(DataGridView dGV)
        {
            var headers = new string[] { "Mã sản phẩm", "Tên sản phẩm", "Loại sản phẩm", "Hãng sản xuất", "Giá thành" };
            FormatHeaderDGV(dGV, headers);
        }

        public static void FormatGuestTempCartDGV(DataGridView dGV)
        {
            var headers = new string[] { "Mã sản phẩm", "Tên sản phẩm", "Số lượng", "Giá thành" };
            FormatHeaderDGV(dGV, headers);
        }

        public static void FormatGuestWishListDGV(DataGridView dGV)
        {
            var headers = new string[] { "Mã sản phẩm", "Tên sản phẩm", "Giá thành" };
            FormatHeaderDGV(dGV, headers);
        }

        public static void FormatGuestOrdersDGV(DataGridView dGV)
        {
            var headers = new string[] { "Mã đơn hàng", "Số chứng minh thư", "Tên khách hàng", "Địa chỉ", "Số điện thoại", "Số lượng", "Tổng tiền", "Tình trạng" };
            FormatHeaderDGV(dGV, headers);
        }

        public static void FormatAdminProductDGV(DataGridView dGV)
        {
            var headers = new string[] { "Mã sản phẩm", "Tên sản phẩm", "Loại sản phẩm", "Hãng sản xuất", "Ngày sản xuất", "Số ngày bảo hành", "Số lượng còn lại", "Giá thành" };
            FormatHeaderDGV(dGV, headers);
        }

        public static void FormatAdminOrders(DataGridView dGV)
        {
            var headers = new string[] { "Mã sản phẩm", "Tên sản phẩm", "Số lượng", "Giá" };
            FormatHeaderDGV(dGV, headers);
        }

        public static void BindingProductDatasIntoControls(TextBox tBProductName, TextBox tBQuantity, TextBox tBPrice, DataGridView dGVProducts)
        {
            tBProductName.DataBindings.Clear();
            tBQuantity.DataBindings.Clear();
            tBPrice.DataBindings.Clear();

            tBProductName.DataBindings.Add("Text", dGVProducts.DataSource, "productName");
            tBQuantity.Text = "1";
            tBPrice.DataBindings.Add("Text", dGVProducts.DataSource, "productPrice");
        }

        public static void BindingProductDatasIntoControls(TextBox tBProductID, TextBox tBProductName,
            TextBox tBTypeOfProduct, TextBox tBBrand, DateTimePicker dTDateOfManufacture, TextBox tBQuanranty,
            TextBox tBRemainingQuantity, TextBox tBPrice, DataGridView dGVProducts)
        {
            tBProductID.DataBindings.Clear();
            tBProductName.DataBindings.Clear();
            tBTypeOfProduct.DataBindings.Clear();
            tBBrand.DataBindings.Clear();
            dTDateOfManufacture.DataBindings.Clear();
            tBRemainingQuantity.DataBindings.Clear();
            tBQuanranty.DataBindings.Clear();
            tBPrice.DataBindings.Clear();

            tBProductID.DataBindings.Add("Text", dGVProducts.DataSource, "productId");
            tBProductName.DataBindings.Add("Text", dGVProducts.DataSource, "productName");
            tBTypeOfProduct.DataBindings.Add("Text", dGVProducts.DataSource, "productType");
            tBBrand.DataBindings.Add("Text", dGVProducts.DataSource, "brand");
            dTDateOfManufacture.DataBindings.Add("Text", dGVProducts.DataSource, "manufracturingDate");
            tBRemainingQuantity.DataBindings.Add("Text", dGVProducts.DataSource, "remaining", true, DataSourceUpdateMode.OnPropertyChanged);
            tBQuanranty.DataBindings.Add("Text", dGVProducts.DataSource, "quaranty", true, DataSourceUpdateMode.OnPropertyChanged);
            tBPrice.DataBindings.Add("Text", dGVProducts.DataSource, "productPrice", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void BindingProductDatasIntoControls(DataGridView dGVCart, TextBox tBQuantity, TextBox tBTotalPrice)
        {
            tBQuantity.Text = dGVCart.Rows.Count.ToString();

            int price = 0;
            for (int i = 0; i < dGVCart.Rows.Count; i++)
            {
                price += int.Parse(dGVCart.Rows[i].Cells["productPrice"].Value.ToString());
            }
            tBTotalPrice.Text = price.ToString();
        }
    }
}
