using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.DAL;

namespace v1.Repositories
{
    class OrdersRepository : IOrdersRepository
    {
        private CCMEntities CCM_Database = new CCMEntities();
        public IEnumerable<object> FetchOrders(string guestID)
        {
            return CCM_Database.BILLs.Where(b => b.GUEST.Contains(guestID))
                .Join(CCM_Database.GUEST_INFO, b => b.GUEST, g => g.ID,
                (b, g) => new
                {
                    billID = b.ID,
                    guestID = g.ID,
                    guesName = g.GUEST_NAME,
                    guestAddress = g.GUEST_ADDRESS,
                    guestPhone = g.PHONE,
                    quantity = b.QUANTITY,
                    total = b.TOTAL,
                    billStatus = b.BILL_STATUS,
                })
                .ToList();
        }
    }
}
