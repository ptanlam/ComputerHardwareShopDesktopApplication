using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1
{
    interface IProductRepository
    {
        public IEnumerable<object> FetchProductsData(string category);
    }
}
