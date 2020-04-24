using Yanomami.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.EntityFrameworkCore;

namespace Yanomami.DbMigrator
{
    [DependsOn(
        typeof(YanomamiEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule)
        )]
    public class YanomamiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlite();
            });
        }
    }
}
