// Task Ventilator
// Binds PUSH socket to tcp://localhost:5557
// Sends batch of tasks to workers via that socket
using NetMQ;
using NetMQ.Sockets;

Console.WriteLine("====== VENTILATOR ======");
using (var sink = new PullSocket(">tcp://localhost:5558"))
{
    Console.WriteLine("Press enter when worker are ready");
    Console.ReadLine();
    //the first message it "0" and signals start of batch
    //see the Sink.csproj Program.cs file for where this is used
    Console.WriteLine("Sending start of batch to Sink");
    sink.SendFrame("0");
    Console.WriteLine("Sending tasks to workers");

    Console.WriteLine("Press Enter to quit");
    Console.ReadLine();
}