using Confluent.Kafka;

var broker = "10.26.7.58:9092";
var topics = "FIT.BDRD.Test";

Run_Consume(broker, topics, default);



static void Run_Consume(string brokerList, string topics, CancellationToken cancellationToken)
{

    var config = new ConsumerConfig
    {
        BootstrapServers = brokerList,
        GroupId = "TestConsumeJson",
        EnableAutoCommit = false,
        StatisticsIntervalMs = 5000,
        SessionTimeoutMs = 6000,
        AutoOffsetReset = AutoOffsetReset.Earliest,
        //EnablePartitionEof = true,
        //PartitionAssignmentStrategy = PartitionAssignmentStrategy.CooperativeSticky
    };

    const int commitPeriod = 5;

    using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
    {
        consumer.Subscribe(topics);

        try
        {
            while (true)
            {
                try
                {
                    var consumeResult = consumer.Consume(cancellationToken);

                    if (consumeResult.Offset == 0)
                    {
                        Console.WriteLine($"Start ======== {DateTime.Now}");
                    }

                    consumer.Commit(consumeResult);
                    if (consumeResult.Offset == 99999)
                    {
                        Console.WriteLine($"Start ======== {DateTime.Now}");
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