using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;

namespace Yanomami.EntityFrameworkCore
{
    [DependsOn(
        typeof(YanomamiDomainModule),
        typeof(AbpEntityFrameworkCoreSqliteModule)
        )]
    public class YanomamiEntityFrameworkCoreModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            YanomamiEfCoreEntityExtensionMappings.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<YanomamiDbContext>(options =>
            {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also YanomamiMigrationsDbContextFactory for EF Core tooling. */
                options.UseSqlite<YanomamiDbContext>();

            });

        }
    }
}
