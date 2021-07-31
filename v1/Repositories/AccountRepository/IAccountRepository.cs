using System.Collections.Generic;

namespace v1.Repositories.AccountRepository
{
    interface IAccountRepository
    {
        public object FetchAccount(string username);
    }
}