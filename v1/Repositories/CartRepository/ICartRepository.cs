using System.Collections.Generic;
using System.Linq;

namespace v1.Repositories.CartRepository
{
    interface ICartRepository
    {
        public IEnumerable<object> FetchCartData(string billID);
    }
}