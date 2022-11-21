using Grpc.Core;
using GrpcServer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServerBasic.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context) {
            CustomerModel output = new CustomerModel();

            if(request.UserId == 1)
            {
                output.FirstName = "Jamie";
                output.LastName = "Smith";
            }
            else if(request.UserId == 2)
            {
                output.FirstName = "Jane";
                output.LastName = "Doe";
                output.Age = Int32.Parse(request.Age);
                output.EmailAddress = request.Name;
            }
            else
            {
                output.FirstName = "Greg";
                output.LastName = "Thomast";
            }

            return Task.FromResult(output);
        }

        public override async Task GetNewCustomers(NewCustomerRequest request, IServerStreamWriter<CustomerModel> responseStream, ServerCallContext context)
        {
            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel
                {
                    FirstName = "Tim",
                    LastName = "Corey",
                    EmailAddress = "long@gmail.com",
                    Age = 18,
                    IsAlive = true
                },
                new CustomerModel
                {
                    FirstName = "Long1",
                    LastName = "Phi2",
                    EmailAddress = "lon11g@gmail.com",
                    Age = 38,
                    IsAlive = true
                },
                new CustomerModel
                {
                    FirstName = "Long1111",
                    LastName = "Long123",
                    EmailAddress = "long1123@gmail.com",
                    Age = 28,
                    IsAlive = true
                },
            };

            foreach (var cust in customers)
            {
                //await Task.Delay(1000);
                await responseStream.WriteAsync(cust);
            }
        }
    }
}
