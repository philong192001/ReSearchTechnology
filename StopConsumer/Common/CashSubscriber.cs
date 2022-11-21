namespace StopConsumer.Common
{
    public class CashSubscriber : ICashSubscriber 
    {
        private CancellationTokenSource _cancelTokenSourceCash;
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _services;
        private readonly string _topic;

        public CashSubscriber(IConfiguration configuration, IServiceProvider services)
        {
            _configuration = configuration;
            _services = services;
            _topic = configuration["Kafka:Topics:AccountCashTopic"];

        }

        public bool IsRunning { get; private set; } = false;

        public bool Start()
        {
            if (IsRunning == false)
            {
                var consumerConfig = new SubscriberBuilderConfiguration
                {
                    BootstrapServers = _configuration["Kafka:BootstrapServers"],
                    GroupId = _configuration["Kafka:GroupIds:CashTopicGroupId"],
                    AutoOffsetReset = 1,
                    EnableAutoCommit = false,
                    EnableAutoOffsetStore = false,
                    CommitWhenSuccess = true,
                };

                var subscriber = new KafkaSubscriber<string, string>(consumerConfig, null);

                var subscriberService = new KafkaSubscriberService<string, string>(subscriber);

                _cancelTokenSourceCash = new CancellationTokenSource();

                subscriberService.StartSubscribeTask(action: Consume, topic: _topicCash, cancellationToken: _cancelTokenSourceCash.Token);
                IsRunning = true;

                return true;
            }
            return false;
        }

        public bool Stop()
        {
            if (_cancelTokenSourceCash != null && !_cancelTokenSourceCash.IsCancellationRequested)
            {
                _cancelTokenSourceCash.Cancel();
                IsRunning = false;

                return true;
            }
            return false;
        }

        private bool Consume(ConsumeResult<string, string>? result)
        {
            using var activity = _telemetry.ActivitySource.StartActivity(nameof(ManageCashSubscriber));

            try
            {
                var command = JsonSerializer.Deserialize<UpdateCashCommand>(result.Message.Value);
                command.Offset = result.Offset.Value;
                command.Partition = result.Partition.Value;
                command.TopicName = result.Topic.ToString();

                if (command == null || !command.IsValid())
                    return true;

                command.TopicName = result.Topic;
                command.Partition = result.Partition.Value;
                command.Offset = result.Offset.Value;

                activity?.SetTag("Business Type", command.BusinessType);
                activity?.SetTag("ClientCode", command.ClientCode);

                var services = _services.CreateScope();

                var mediator = services.ServiceProvider.GetRequiredService<IMediator>();

                mediator.Send(command).Wait();

                activity?.SetStatus(ActivityStatusCode.Ok);

                return true;
            }
            catch (Exception ex)
            {
                activity?.SetTag("Error exception", ex);
                activity?.SetStatus(ActivityStatusCode.Error);

                Console.WriteLine(ex.Message + $"Topic: {_topicCash}\n" +
                    $"Partition: {result.Partition}\n" +
                    $"offset: {result.Offset}\n" +
                    $"Message: {result.Message.Value}\n" +
                    $"{ex.ToString()}");

                _logger.LogError($"Topic: {_topicCash}\n" +
                    $"Partition: {result.Partition}\n" +
                    $"offset: {result.Offset}\n" +
                    $"Message: {result.Message.Value}\n" +
                    $"{ex.ToString()}");

                return true;
            }
        }
    }
}
