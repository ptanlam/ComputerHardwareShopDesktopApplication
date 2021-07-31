using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1.Repositories.TempCartRepository
{
    interface ITempCartRepository
    {
        public IEnumerable<object> FetchTempCartData();
    }
}
