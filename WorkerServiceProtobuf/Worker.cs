using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProtoBuf;
using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerServiceProtobuf
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);

                Project pObj = new Project
                {
                    ID = 12345,
                    Name = "Fred",
                };

                //Thoi gian Start serialize
                Console.WriteLine($"Start serialize: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ffff")}");
                //Serialize obj -> byte[] (cung luc do cache vao ram , co che cua Protobuf-net la nhu vay)
                byte[] bytes = ProtoSerialize(pObj);
                //Thoi gian End serialize
                Console.WriteLine($"End serialize: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ffff")}");

                //Thoi gian Start Deserialize
                Console.WriteLine($"Start deserialize: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ffff")}");
                //Deserialize byte[] -> obj
                var a = ProtoDeserialize<Project>(bytes);
                //Thoi gian End Deserialize
                Console.WriteLine($"End deserialize: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ffff")}");

                //Convert obj -> json
                Console.WriteLine(JsonSerializer.Serialize(a));
            }
        }

        //Serialize
        public static byte[] ProtoSerialize<T>(T record) where T : class
        {
            if (null == record) return null;

            try
            {
                //su dung MemoryStream cache vao Ram
                using (var stream = new MemoryStream())
                {
                    //cache vao Ram duoi dang binary
                    Serializer.Serialize(stream, record);
                    return stream.ToArray();
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

        //Deserialize
        public static T ProtoDeserialize<T>(byte[] data) where T : class
        {
            if (null == data) return null;

            try
            {
                //su dung MemoryStream read trong Ram
                using (var stream = new MemoryStream(data))
                {
                    return Serializer.Deserialize<T>(stream);
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }
    }

    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
    }

    [ProtoContract(SkipConstructor = true)]
    public class Project
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }
    }
}
