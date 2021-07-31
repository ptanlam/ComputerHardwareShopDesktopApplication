using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.Action.Admin;
using v1.Action.Guest;

namespace v1.Action
{
    class UserAction : IUserAction
    {
        public IAdminAction AdminAction()
        {
            return new AdminAction();
        }

        public IGuestAction GuestAction()
        {
            return new GuestAction();
        }
    }
}
