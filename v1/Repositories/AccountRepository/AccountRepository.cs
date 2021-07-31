using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.DAL;

namespace v1.Repositories.AccountRepository
{
    class AccountRepository : IAccountRepository
    {
        CCMEntities CCM_Database = new CCMEntities();
        public object FetchAccount(string username)
        {
            return CCM_Database.ACCOUNTs.Where(a => a.USERNAME == username)
                .Select(a => new
                {
                    password = a.USER_PASSWORD
                }).SingleOrDefault();
        }
    }
}
