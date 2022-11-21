using Locust.LoadTestHttp.Models;

namespace Locust.LoadTestHttp.KafkaBus
{
    public interface IProducerOrder
    {
        string Producer(Order order);
    }
}
