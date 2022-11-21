using Core.Marten;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Payments.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public static class Config
    {
        public static void AddPaymentsModule(this IServiceCollection services, IConfiguration config)
        {
            services.AddMarten(config, options =>
            {
                options.ConfigurePayments();
            });
            services.AddPayments();
        }
    }
}
