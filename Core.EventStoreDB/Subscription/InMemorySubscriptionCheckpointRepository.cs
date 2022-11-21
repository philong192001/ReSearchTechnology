using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.EventStoreDB.Subscription
{
    public class InMemorySubscriptionCheckpointRepository: ISubscriptionCheckpointRepository
    {
        private readonly ConcurrentDictionary<string, ulong> checkpoints = new();

        public ValueTask<ulong?> Load(string subscriptionId, CancellationToken ct)
        {
            return new(checkpoints.TryGetValue(subscriptionId, out var checkpoint) ? checkpoint : null);
        }

        public ValueTask Store(string subscriptionId, ulong position, CancellationToken ct)
        {
            checkpoints.AddOrUpdate(subscriptionId, position, (_, _) => position);

            return ValueTask.CompletedTask;
        }
    }
}
