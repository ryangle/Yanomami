using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Yanomami
{
    [DependsOn(
        typeof(YanomamiDomainModule),
        typeof(YanomamiApplicationContractsModule),
        typeof(AbpDddApplicationModule)
        )]
    public class YanomamiApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<YanomamiApplicationModule>();
            });
        }
    }
}
