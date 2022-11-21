using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.EventStoreDB.Subscription
{
    public interface ISubscriptionCheckpointRepository
    {
        ValueTask<ulong?> Load(string subscriptionId, CancellationToken ct);

        ValueTask Store(string subscriptionId, ulong position, CancellationToken ct);
    }
}
