using Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Payments.FinalizingPayment
{
    public class PaymentFinalized : IExternalEvent
    {
        public Guid OrderId { get; }

        public Guid PaymentId { get; }

        public decimal Amount { get; }

        public DateTime FinalizedAt { get; }

        public PaymentFinalized(Guid orderId, Guid paymentId, decimal amount, DateTime finalizedAt)
        {
            OrderId = orderId;
            PaymentId = paymentId;
            Amount = amount;
            FinalizedAt = finalizedAt;
        }
    }
}
