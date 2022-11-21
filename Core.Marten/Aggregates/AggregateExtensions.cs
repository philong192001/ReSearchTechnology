using Core.Aggregates;
using Core.Events;
using Marten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Marten.Aggregates
{
    public static class AggregateExtensions
    {
        public static async Task StoreAndPublishEvents(
            this IAggregate aggregate,
            IDocumentSession session,
            IEventBus eventBus,
            CancellationToken cancellationToken = default
        )
        {
            var uncommitedEvents = aggregate.DequeueUncommittedEvents();
            session.Events.Append(aggregate.Id, uncommitedEvents);
            await session.SaveChangesAsync(cancellationToken);
            await eventBus.Publish(uncommitedEvents);
        }
    }
}
