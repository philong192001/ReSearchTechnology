using Core.Commands;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Payments.Payments.RequestingPayment
{
    public class RequestPayment : ICommand
    {
        public Guid PaymentId { get; }

        public Guid OrderId { get; }

        public decimal Amount { get; }

        private RequestPayment(
            Guid paymentId,
            Guid orderId,
            decimal amount
        )
        {
            PaymentId = paymentId;
            OrderId = orderId;
            Amount = amount;
        }
        public static RequestPayment Create(
            Guid? paymentId,
            Guid? orderId,
            decimal? amount
        )
        {
            if (paymentId == null || paymentId == Guid.Empty)
                throw new ArgumentOutOfRangeException(nameof(paymentId));
            if (orderId == null || orderId == Guid.Empty)
                throw new ArgumentOutOfRangeException(nameof(orderId));
            if (amount is null or <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            return new RequestPayment(paymentId.Value, orderId.Value, amount.Value);
        }
    }
    public class HandleRequestPayment :
        ICommandHandler<RequestPayment>
    {
        private readonly IRepository<Payment> paymentRepository;

        public HandleRequestPayment(
            IRepository<Payment> paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }

        public async Task<Unit> Handle(RequestPayment command, CancellationToken cancellationToken)
        {
            var payment = Payment.Initialize(command.PaymentId, command.OrderId, command.Amount);

            await paymentRepository.Add(payment, cancellationToken);

            return Unit.Value;
        }
    }
}
