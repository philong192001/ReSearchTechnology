
using Confluent.Kafka;
using Core.Streaming.Kafka.Consumers;

static void Run_Consume(string brokerList,string topics, CancellationToken cancellationToken)
{

    var config = new ConsumerConfig
    {
        BootstrapServers = brokerList,
        GroupId = "tradingt.CDC.TCDC_CASH_CASH_ACLConsumerGroup_thanhvd2test",
        EnableAutoCommit = false,
        //StatisticsIntervalMs = 5000,
        //SessionTimeoutMs = 6000,
        AutoOffsetReset = AutoOffsetReset.Earliest,
        //EnablePartitionEof = true,
        //PartitionAssignmentStrategy = PartitionAssignmentStrategy.CooperativeSticky
    };

    const int commitPeriod = 5;

    using (var consumer = new ConsumerBuilder<Ignore, string>(config)
    //    .SetErrorHandler((_, e) => Console.WriteLine($"Error: {e.Reason}"))
    //    .SetStatisticsHandler((_, json) => Console.WriteLine($"Statistics: {json}"))
    //    .SetPartitionsAssignedHandler((c, partitions) =>
    //    {
    //        Console.WriteLine(
    //    "Partitions incrementally assigned: [" +
    //    string.Join(',', partitions.Select(p => p.Partition.Value)) +
    //    "], all: [" +
    //    string.Join(',', c.Assignment.Concat(partitions).Select(p => p.Partition.Value)) +
    //    "]");

    //    })
    //    .SetPartitionsRevokedHandler((c, partitions) =>
    //    {
    //        var remaining = c.Assignment.Where(atp => partitions.Where(rtp => rtp.TopicPartition == atp).Count() == 0);
    //        Console.WriteLine(
    //            "Partitions incrementally revoked: [" +
    //            string.Join(',', partitions.Select(p => p.Partition.Value)) +
    //            "], remaining: [" +
    //            string.Join(',', remaining.Select(p => p.Partition.Value)) +
    //            "]");
    //    })
    //    .SetPartitionsLostHandler((c, partitions) =>
    //    {
    //        Console.WriteLine($"Partitions were lost: [{string.Join(", ", partitions)}]");
    //    })
        .Build())
    {
        consumer.Subscribe(topics);

        try
        {
            while (true)
            {
                try
                {
                    var consumeResult = consumer.Consume(cancellationToken);

                    if (consumeResult.IsPartitionEOF)
                    {
                        Console.WriteLine(
                            $"Reached end of topic {consumeResult.Topic}, partition {consumeResult.Partition}, offset {consumeResult.Offset}.");

                        continue;
                    }

                    Console.WriteLine($"Received message at {consumeResult.TopicPartitionOffset}: {consumeResult.Message.Value}");

                    if (consumeResult.Offset % commitPeriod == 0)
                    {
                        try
                        {
                            consumer.Commit(consumeResult);
                        }
                        catch (KafkaException e)
                        {
                            Console.WriteLine($"Commit error: {e.Error.Reason}");
                        }
                    }
                }
                catch (ConsumeException e)
                {
                    Console.WriteLine($"Consume error: {e.Error.Reason}");
                }
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Closing consumer.");
           // consumer.Close();
        }
    }
}

static void Run_ManualAssign(string brokerList,string topic, CancellationToken cancellationToken)
{
    var config = new ConsumerConfig
    {
        GroupId = "tradingt.CDC.TCDC_CASH_CASH_ACLConsumerGroup_thanhvd2test",
        BootstrapServers = brokerList,
        EnableAutoCommit = true,
        AutoOffsetReset = AutoOffsetReset.Latest,
        ClientId = Guid.NewGuid().ToString(),  

    };

    using (var consumer =
        new ConsumerBuilder<string, string>(config)
            .SetErrorHandler((_, e) => Console.WriteLine($"Error: {e.Reason}"))
            .Build())
    {
        //consumer.Assign(new TopicPartitionOffset(topic, 0, Offset.Beginning));
        TopicPartition partitionToReadFrom = new TopicPartition(topic, 0);
        consumer.Assign(partitionToReadFrom);

        try
        {
            while (true)
            {
                try
                {
                    var consumeResult = consumer.Consume(cancellationToken);
                    Console.WriteLine($"Received message at {consumeResult.TopicPartitionOffset}: ${consumeResult.Message.Value}");
                }
                catch (ConsumeException e)
                {
                    Console.WriteLine($"Consume error: {e.Error.Reason}");
                }
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Closing consumer.");
            consumer.Close();
        }
    }
}

static void PrintUsage() => Console.WriteLine("Usage: .. <subscribe|manual> <broker,broker,..> <topic> [topic..]");



//Main



//if (args.Length < 3)
//{
//    PrintUsage();
//    return;
//}

var mode = "manual";
var brokerList = "10.26.7.58:9092,10.26.7.59:9092,10.26.7.60:9092";
var topics = "tradingt.CDC.TCDC_CASH";

//Console.WriteLine($"Started consumer, Ctrl-C to stop consuming");

CancellationTokenSource cts = new CancellationTokenSource();

Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true; // prevent the process from terminating.
    cts.Cancel();
};
Run_ManualAssign(brokerList, topics, cts.Token);

//switch (mode)
//{
//    case "subscribe":
//    //Run_Consume(brokerList, topics, cts.Token);
//    break;
//    case "manual":
//    Run_ManualAssign(brokerList, topics, cts.Token);
//    break;
//    default:
//    PrintUsage();
//    break;
//}