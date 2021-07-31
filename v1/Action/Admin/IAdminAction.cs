using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1.Action.Admin
{
    interface IAdminAction
    {
        bool AddProduct(string productID, string productName, string type, string brand, string manufracturingDate, int quaranty, int remainingQuantity, int price);
        bool DeleteProduct(string productID);
        bool UpdateProduct(string productID, string productName, string type, string brand, string manufracturingDate, int quaranty, int remainingQuantity, int price);
        bool ApproveOrder(string billID);
        bool CompleteOrder(string billID);
    }
}
