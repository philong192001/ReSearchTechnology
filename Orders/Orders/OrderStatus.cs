using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Orders
{
    public enum OrderStatus
    {
        Initialized = 1,
        Paid = 2,
        Completed = 4,
        Cancelled = 8,
        Closed = Completed | Cancelled
    }
}
