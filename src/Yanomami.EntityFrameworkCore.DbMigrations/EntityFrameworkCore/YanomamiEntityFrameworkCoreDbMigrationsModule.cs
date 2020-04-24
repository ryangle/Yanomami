using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Yanomami.EntityFrameworkCore
{
    [DependsOn(
        typeof(YanomamiEntityFrameworkCoreModule)
        )]
    public class YanomamiEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<YanomamiMigrationsDbContext>();
        }
    }
}
