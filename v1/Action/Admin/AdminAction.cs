using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1.DAL;

namespace v1.Action.Admin
{
    class AdminAction : IAdminAction
    {
        private CCMEntities CCM_Database = new CCMEntities();
        public bool AddProduct(string productID, string productName, string type, string brand, 
            string manufracturingDate, int quaranty, int remainingQuantity, int price)
        {
            PRODUCT product = CCM_Database.PRODUCTs.Where(p => p.ID == productID).SingleOrDefault();
            if (product != null)
            {
                return false;
            }
            else
            {
                product = new PRODUCT
                {
                    ID = productID,
                    PRODUCT_NAME = productName,
                    PRODUCT_TYPE = type,
                    BRAND = brand,
                    MANUFRACTURING_DATE = DateTime.Parse(manufracturingDate),
                    QUARANTY = quaranty,
                    REMAINING = remainingQuantity,
                    PRICE = price
                };
                CCM_Database.PRODUCTs.Add(product);
                CCM_Database.SaveChanges();
                return true;
            }
        }

        public bool DeleteProduct(string productID)
        {
            PRODUCT product = CCM_Database.PRODUCTs.Where(p => p.ID == productID).SingleOrDefault();
            if (product == null)
            {
                return false;
            }
            else
            {
                CCM_Database.PRODUCTs.Remove(product);
                CCM_Database.SaveChanges();
                return true;
            }
        }

        public bool UpdateProduct(string productID, string productName, string type, string brand, 
            string manufracturingDate, int quaranty, int remainingQuantity, int price)
        {
            PRODUCT product = CCM_Database.PRODUCTs.Where(p => p.ID == productID).SingleOrDefault();
            if (product == null)
            {
                return false;
            }
            else
            {
                product.PRODUCT_NAME = productName;
                product.PRODUCT_TYPE = type;
                product.BRAND = brand;
                product.MANUFRACTURING_DATE = DateTime.Parse(manufracturingDate);
                product.QUARANTY = quaranty;
                product.REMAINING = remainingQuantity;
                product.PRICE = price;
                CCM_Database.SaveChanges();
                return true;
            }
        }

        public bool ApproveOrder(string billID)
        {
            var cart = CCM_Database.CARTs.Where(c => c.BILL == billID).ToList();
            foreach (var item in cart)
            {
                var product = CCM_Database.PRODUCTs.Where(p => p.ID == item.PRODUCT).SingleOrDefault();
                if (product.REMAINING < item.QUANTITY) return false;
                product.REMAINING -= item.QUANTITY;
            }
            var bill = CCM_Database.BILLs.Where(b => b.ID == billID).SingleOrDefault();
            bill.BILL_STATUS = "Đã duyệt - Đang vận chuyển";
            bill.IS_APPROVED = true;
            CCM_Database.SaveChanges();
            return true;
        }

        public bool CompleteOrder(string billID)
        {
            var bill = CCM_Database.BILLs.Where(b => b.ID == billID).SingleOrDefault();
            if ((bool)bill.IS_APPROVED)
            {
                var cart = CCM_Database.CARTs.Where(c => c.BILL == billID).ToList();
                foreach (var item in cart)
                {
                    CCM_Database.CARTs.Remove(item);
                }
                CCM_Database.BILLs.Remove(bill);
                CCM_Database.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
