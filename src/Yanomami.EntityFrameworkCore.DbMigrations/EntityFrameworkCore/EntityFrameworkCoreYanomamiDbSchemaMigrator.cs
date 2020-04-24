using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Yanomami.Data;
using Volo.Abp.DependencyInjection;

namespace Yanomami.EntityFrameworkCore
{
    public class EntityFrameworkCoreYanomamiDbSchemaMigrator
        : IYanomamiDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreYanomamiDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the YanomamiMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<YanomamiMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}