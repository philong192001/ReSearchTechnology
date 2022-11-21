using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GrpcClientBasic
{
    internal class Program
    {
        static async Task  Main(string[] args)
        {
            //var input = new HelloRequest { Name = "Long" };
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);
            //var reply = await client.SayHelloAsync(input);
            //Console.WriteLine(reply.Message);
            await TestGrpc();
            Demo();
        }

        private static void Demo()
        {
            Console.WriteLine("123");
        }

        public static async Task TestGrpc()
        {
            //List<CustomerModel> list = new List<CustomerModel>();
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var customerClient = new Customer.CustomerClient(channel);
            var clientRequest = new CustomerLookupModel { UserId = 2, Age = "123", Name = "LONGLONGLONGLONGLONGLONGLONGLONGLONGLONGLONGLONG", Room = "LONGLONGLONGLONGLONGLONGLONGLONGLONG" };
            var customer = await customerClient.GetCustomerInfoAsync(clientRequest);
            //Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Age} {customer.EmailAddress}");

            Console.WriteLine("New Customer List");


            for (var i = 0; i < 100000; i++)
            {
                using (var call = customerClient.GetNewCustomers(new NewCustomerRequest()))
                {
                    while (await call.ResponseStream.MoveNext())
                    {
                        var currentCustomer = call.ResponseStream.Current;
                        //list.Add(currentCustomer);
                        Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Age} {customer.EmailAddress} : {currentCustomer}");
                    }
                }
            }
            //Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Age} {customer.EmailAddress} : {list}");
            Console.ReadLine();
        }
    }

}
