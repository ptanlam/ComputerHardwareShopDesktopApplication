using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.DAL;

namespace v1.Repositories.WishListRepository
{
    class WishListRepository : IWishListRepository
    {
        CCMEntities CCM_Database = new CCMEntities();

        public IEnumerable<object> FetchWishListData()
        {
            return CCM_Database.WISHLISTs.Select(wl =>
            new
            {
                productID = wl.PRODUCT,
                productName = wl.PRODUCT_NAME,
                productPrice = wl.PRICE,
            }).ToList();
        }
    }
}
