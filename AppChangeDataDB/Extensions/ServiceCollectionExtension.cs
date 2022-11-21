using AppChangeDataDB.Data;
using Microsoft.EntityFrameworkCore;

namespace AppChangeDataDB.Extensions
{
    public static class ServiceCollectionExtension
    {
        private const string DB_CONNECTION_NAME_1 = "DBOracle1";
        private const string DB_CONNECTION_NAME_2 = "DBOracle2";


        public static IServiceCollection UseServiceCollectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services
                    .AddDBContext(configuration);
            return services;
        }
        private static IServiceCollection AddDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            {
                //account15
                var connection = configuration["ConnectionStrings:" + DB_CONNECTION_NAME_1];

                //hzcast01
                var connection2 = configuration["ConnectionStrings:" + DB_CONNECTION_NAME_2];


                services
                .AddDbContext<AccountDbContext>(p => p.UseOracle(connection))
                .AddDbContext<AccountDbContextClone>(p => p.UseOracle(connection2));

                return services;
            }
        }

    }
}
