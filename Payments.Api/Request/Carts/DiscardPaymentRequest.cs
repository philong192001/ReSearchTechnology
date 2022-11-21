using Payments.Payments.DiscardingPayment;

namespace Payments.Api.Request.Carts
{
    public class DiscardPaymentRequest
    {
        public DiscardReason DiscardReason { get; set; }
    }
}
