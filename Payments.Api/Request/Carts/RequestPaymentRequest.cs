using System;

namespace Payments.Api.Request.Carts
{
    public class RequestPaymentRequest
    {
        public Guid OrderId { get; set; }

        public decimal Amount { get; set; }
    }
}
