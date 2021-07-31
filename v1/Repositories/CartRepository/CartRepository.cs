using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.DAL;

namespace v1.Repositories.CartRepository
{
    class CartRepository : ICartRepository
    {
        private CCMEntities CCM_Database = new CCMEntities();
        public IEnumerable<object> FetchCartData(string billID)
        {
            return CCM_Database.CARTs.Where(c => c.BILL == billID)
                .Select(c => new
                {
                    productsID = c.PRODUCT,
                    productName = c.PRODUCT_NAME,
                    quantity = c.QUANTITY,
                    productPrice = c.PRICE
                });
        }
    }
}
