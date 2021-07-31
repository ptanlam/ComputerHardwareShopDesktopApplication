using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1.Action.Guest;
using v1.Repositories;
using v1.Repositories.AccountRepository;
using v1.Repositories.CartRepository;
using v1.Repositories.TempCartRepository;
using v1.Repositories.WishListRepository;
using v1.UIFormat;

namespace v1.Action.System
{
    class SystemAction
    {
        public static void LoadProducts(string category, TextBox tBProductName, 
            TextBox tBQuantity, TextBox tBPrice, DataGridView dGVProducts, IProductRepository productRepository)
        {
            var listOfProducts = productRepository.FetchProductsData(category);
            dGVProducts.DataSource = listOfProducts;
            Format_Binding.FormatGuestProductDGV(dGVProducts);
            Format_Binding.BindingProductDatasIntoControls(tBProductName, tBQuantity, tBPrice, dGVProducts);
        }

        public static void LoadProducts(string category, TextBox tBProductId, TextBox tBProductName, 
            TextBox tBTypeOfProduct, TextBox tBBrand, DateTimePicker dTDateOfManufacture, TextBox tBQuanranty, 
            TextBox tBRemainingQuantity, TextBox tBPrice, DataGridView dGVProducts, IProductRepository productRepository)
        {
            var listOfProducts = productRepository.FetchProductsData(category);
            dGVProducts.DataSource = listOfProducts;
            Format_Binding.FormatAdminProductDGV(dGVProducts);
            Format_Binding.BindingProductDatasIntoControls(tBProductId, tBProductName, tBTypeOfProduct, tBBrand, 
                dTDateOfManufacture, tBQuanranty, tBRemainingQuantity, tBPrice, dGVProducts);
        }

        public static void LoadTempCart(DataGridView dGVCart, ITempCartRepository tempCartRepository)
        {
            var tempCart = tempCartRepository.FetchTempCartData();
            try
            {
                dGVCart.DataSource = tempCart;
                Format_Binding.FormatGuestTempCartDGV(dGVCart);
            }
            catch (ArgumentOutOfRangeException)
            {
                dGVCart.DataSource = tempCart.ToList();
            }
        }

        public static void LoadTempCart(DataGridView dGVCart, ITempCartRepository tempCartRepository,
            TextBox tBQuantity, TextBox tBTotalPrice)
        {
            var tempCart = tempCartRepository.FetchTempCartData();
            dGVCart.DataSource = tempCart;
            Format_Binding.FormatGuestTempCartDGV(dGVCart);
            Format_Binding.BindingProductDatasIntoControls(dGVCart, tBQuantity, tBTotalPrice);
        }

        public static void LoadWishList(DataGridView dGVFav, IWishListRepository wishListRepository)
        {
            var wishList = wishListRepository.FetchWishListData();
            try
            {
                dGVFav.DataSource = wishList;
                Format_Binding.FormatGuestWishListDGV(dGVFav);
            }
            catch (ArgumentOutOfRangeException)
            {
                dGVFav.DataSource = wishList.ToList();
            }
        }

        public static void LoadOrders(DataGridView dGVOrders, IOrdersRepository ordersRepository, string guestID = "")
        {
            dGVOrders.DataSource = ordersRepository.FetchOrders(guestID);
            Format_Binding.FormatGuestOrdersDGV(dGVOrders);
        }

        public static void LoadCartDetail(DataGridView dGVCart, ICartRepository cartRepository, string billID)
        {
            dGVCart.DataSource = cartRepository.FetchCartData(billID);
            Format_Binding.FormatAdminOrders(dGVCart);
        }

        public static void GetDataFromControls(out string productID, out string productName, out int productPrice, out int quantity, 
            TextBox tBProductName, TextBox tBQuantity, TextBox tBPrice, DataGridView dGVProducts)
        {
            productID = dGVProducts.CurrentRow.Cells["productID"].Value.ToString();
            productName = tBProductName.Text;
            productPrice = int.Parse(tBPrice.Text);
            quantity = tBQuantity.Text == "" ? 1 : int.Parse(tBQuantity.Text);
        }

        public static void GetDataFromControls(out string productID, out string productName, out string type, out string brand,
            out string manufracturingDate, out int quaranty, out int remainingQuantity, out int productPrice,
            TextBox tBProductId, TextBox tBProductName, TextBox tBTypeOfProduct, TextBox tBBrand,
            DateTimePicker dTDateOfManufacture, TextBox tBQuanranty, TextBox tBRemainingQuantity, TextBox tBPrice)
        {
            productID = tBProductId.Text;
            productName = tBProductName.Text;
            type = tBTypeOfProduct.Text;
            brand = tBBrand.Text;
            manufracturingDate = dTDateOfManufacture.Value.ToString();
            quaranty = int.Parse(tBQuanranty.Text);
            remainingQuantity = int.Parse(tBRemainingQuantity.Text);
            productPrice = int.Parse(tBPrice.Text);
        }

        public static void GetDataFromControls(out List<string> cart, out string guestID, out string guestName, 
            out string guestAddress, out string phone, out int quantity, out int total,
            DataGridView dGVCart, TextBox tBGuestID, TextBox tBGuestName, 
            TextBox tBGuestAddress, TextBox tBPhone, TextBox tBQuantity, TextBox tbTotalPrice)
        {
            cart = dGVCart.Rows.OfType<DataGridViewRow>()
                .Select(p => p.Cells["productID"].Value.ToString())
                .ToList();
            guestID = tBGuestID.Text.ToString();
            guestName = tBGuestName.Text.ToString();
            guestAddress = tBGuestAddress.Text.ToString();
            phone = tBPhone.Text.ToString();
            quantity = int.Parse(tBQuantity.Text.ToString());
            total = int.Parse(tbTotalPrice.Text.ToString());
        }

        public static void ResetPrice(TextBox tBPrice, TextBox tBQuantity, DataGridView dGVProducts)
        {
            tBPrice.Text = dGVProducts.CurrentRow.Cells["productPrice"].Value.ToString();
            tBQuantity.Clear();
        }

        public static bool IsAuthenticated(TextBox tBUsername, TextBox tBPassword, IAccountRepository accountRepossitory)
        {
            var password = accountRepossitory.FetchAccount(tBUsername.Text.ToString());
            if (password == null) return false;
            else if (password.Equals(tBPassword.Text.ToString())) return false;
            return true;
        }
    }
}
