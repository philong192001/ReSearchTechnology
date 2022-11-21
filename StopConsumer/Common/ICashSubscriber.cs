namespace StopConsumer.Common
{
    public interface ICashSubscriber
    {
        bool IsRunning { get; }
        bool Start();
        bool Stop();
    }
}
