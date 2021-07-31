using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.DAL;

namespace v1.Repositories.TempCartRepository
{
    class TempCartRepository : ITempCartRepository
    {
        CCMEntities CCM_Database = new CCMEntities();
        
        public IEnumerable<object> FetchTempCartData()
        {
            return CCM_Database.TEMP_CART.Select(tc => new
            {
                productID = tc.PRODUCT,
                productName = tc.PRODUCT_NAME,
                quantity = tc.QUANTITY,
                productPrice = tc.PRICE,
            }).ToList();
        }
    }
}
