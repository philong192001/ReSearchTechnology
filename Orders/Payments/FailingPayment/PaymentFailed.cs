using Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Payments.FailingPayment
{
    public class PaymentFailed : IExternalEvent
    {
        public Guid OrderId { get; }

        public Guid PaymentId { get; }

        public decimal Amount { get; }

        public DateTime FailedAt { get; }

        public PaymentFailed(Guid orderId, Guid paymentId, decimal amount, DateTime failedAt)
        {
            OrderId = orderId;
            PaymentId = paymentId;
            Amount = amount;
            FailedAt = failedAt;
        }
    }
}
