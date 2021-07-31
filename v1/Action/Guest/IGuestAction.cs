using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1.Action.Guest
{
    interface IGuestAction
    {
        void AddToTempCart(string productID, string productName, int productPrice, int quantity);
        void RemoveProductFromTempCart(string productID);
        bool AddToFav(string productID, string productName, int productPrice);
        void RemoveProductFromWishList(string productID);
        bool CheckNumberValidation(char text);
        int CalculatePrice(int quantity, int price);
        void AddToTempCart(string productID);
        string GenerateBillID(string guestID);
        void AddToRealCart(List<string> cart, string guestID, string guestName, string guestAddress, 
            string phone, int quantity, int total);
    }
}
