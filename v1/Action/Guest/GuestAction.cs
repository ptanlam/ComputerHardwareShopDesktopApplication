using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.Action.System;
using v1.DAL;
using v1.Repositories.TempCartRepository;

namespace v1.Action.Guest
{
    class GuestAction : IGuestAction
    {
        private CCMEntities CCM_Database = new CCMEntities();
        public void AddToTempCart(string productID, string productName, int productPrice, int quantity)
        {
            TEMP_CART temp_cart = CCM_Database.TEMP_CART.Where(tc => tc.PRODUCT == productID).SingleOrDefault();

            if (temp_cart != null)
            {
                temp_cart.QUANTITY += quantity;
            }
            else
            {
                temp_cart = new TEMP_CART
                {
                    PRODUCT = productID,
                    PRODUCT_NAME = productName,
                    PRICE = productPrice,
                    QUANTITY = quantity
                };
                CCM_Database.TEMP_CART.Add(temp_cart);
            }
            CCM_Database.SaveChanges();
        }

        public void AddToTempCart(string productID)
        {
            WISHLIST wish_list = CCM_Database.WISHLISTs.Where(wl => wl.PRODUCT == productID).SingleOrDefault();
            TEMP_CART temp_cart = new TEMP_CART
            {
                PRODUCT = wish_list.PRODUCT,
                PRODUCT_NAME = wish_list.PRODUCT_NAME,
                QUANTITY = 1,
                PRICE = wish_list.PRICE
            };
            CCM_Database.TEMP_CART.Add(temp_cart);
            CCM_Database.SaveChanges();
        }

        public void RemoveProductFromTempCart(string productID)
        {
            TEMP_CART product = CCM_Database.TEMP_CART.Where(tc => tc.PRODUCT == productID).SingleOrDefault();
            CCM_Database.TEMP_CART.Remove(product);
            CCM_Database.SaveChanges();
        }

        public bool AddToFav(string productID, string productName, int productPrice)
        {
            WISHLIST wishlist = CCM_Database.WISHLISTs.Where(wl => wl.PRODUCT == productID).SingleOrDefault();

            if (wishlist != null)
            {
                return false;
            }
            else
            {
                wishlist = new WISHLIST
                {
                    PRODUCT = productID,
                    PRODUCT_NAME = productName,
                    PRICE = productPrice
                };
                CCM_Database.WISHLISTs.Add(wishlist);
                CCM_Database.SaveChanges();
                return true;
            }
        }

        public void RemoveProductFromWishList(string productID)
        {
            WISHLIST wishlist = CCM_Database.WISHLISTs.Where(wl => wl.PRODUCT == productID).SingleOrDefault();
            CCM_Database.WISHLISTs.Remove(wishlist);
            CCM_Database.SaveChanges();
        }

        public bool CheckNumberValidation(char text)
        {
            if (!char.IsControl(text) && !char.IsDigit(text) && (text != '.'))
            {
                return false;
            }
            return true;
        }

        public int CalculatePrice(int quantity, int price) => quantity * price;

        public string GenerateBillID(string guestID) =>
            $"{guestID}{CCM_Database.GUEST_INFO.Where(g => g.ID == guestID).Count()}";

        public void AddToRealCart(List<string> cart, string guestID, string guestName, string guestAddress,
            string phone, int quantity, int total)
        {
            var guest = CCM_Database.GUEST_INFO.Where(g => g.ID == guestID).SingleOrDefault();
            if (guest == null)
            {
                guest = new GUEST_INFO
                {
                    ID = guestID,
                    GUEST_NAME = guestName,
                    GUEST_ADDRESS = guestAddress,
                    PHONE = phone
                };
                CCM_Database.GUEST_INFO.Add(guest);
            }
            var bill = new BILL
            {
                ID = GenerateBillID(guestID),
                QUANTITY = quantity,
                GUEST = guest.ID,
                TOTAL = total,
                BILL_STATUS = "Đang chờ duyệt!",
                IS_APPROVED = false
            };
            CCM_Database.BILLs.Add(bill);
            foreach (var p in cart)
            {
                var temp_cart = CCM_Database.TEMP_CART.Where(tc => tc.PRODUCT == p).SingleOrDefault();
                var real_cart = new CART
                {
                    PRODUCT = temp_cart.PRODUCT,
                    PRODUCT_NAME = temp_cart.PRODUCT_NAME,
                    QUANTITY = temp_cart.QUANTITY,
                    PRICE = temp_cart.PRICE,
                    BILL = bill.ID
                };
                CCM_Database.CARTs.Add(real_cart);
                CCM_Database.TEMP_CART.Remove(temp_cart);
            }
            CCM_Database.SaveChanges();
        }
    }
}
