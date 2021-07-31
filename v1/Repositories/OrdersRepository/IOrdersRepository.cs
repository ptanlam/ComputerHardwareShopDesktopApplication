using System.Collections.Generic;

namespace v1.Repositories
{
    interface IOrdersRepository
    {
        public IEnumerable<object> FetchOrders(string guestID);
    }
}