using Confluent.Kafka;
using Locust.LoadTestHttp.Models;
using System.Net;
using System.Text.Json;

namespace Locust.LoadTestHttp.KafkaBus
{
    public class ProducerOrder : IProducerOrder
    {
        private IConfiguration _config;
        private string _topic;
        private string _bootstrapServers;
        public ProducerOrder(IConfiguration config)
        {
            _config = config;
            _topic = _config["Kafka:Topic"];
            _bootstrapServers = _config["Kafka:BootstrapServer"];
        }

        public string Producer(Order order)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = _bootstrapServers,
                ClientId = Dns.GetHostName()
            };

            var desOrder = JsonSerializer.Serialize(order);

            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                producer.ProduceAsync(_topic, new Message<string, string> { Key = Guid.NewGuid().ToString(), Value = desOrder });

                Console.WriteLine(DateTime.Now + " send " + order + " to " + _topic + " done ");

                producer.Flush();
            }
            return desOrder;

        }
    }
}
