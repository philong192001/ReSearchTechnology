using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Payments.DiscardingPayment
{
    public enum DiscardReason
    {
        UnexpectedError = 0,
        OrderCancelled = 1
    }
}
