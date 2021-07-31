using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.DAL;

namespace v1
{
    class ProductRepositoryForGuest : IProductRepository
    {
        private CCMEntities CCM_Database = new CCMEntities();
        public IQueryable<object> FetchProductsData(string category)
        {
            return CCM_Database.PRODUCTs.Where(p => p.PRODUCT_TYPE == category).Select(p =>
                new
                {
                    productID = p.ID,
                    productName = p.PRODUCT_NAME,
                    productType = p.PRODUCT_TYPE,
                    brand = p.BRAND,
                    productPrice = p.PRICE
                });
        }
    }
}
