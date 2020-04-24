using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace Yanomami
{
    [DependsOn(
        typeof(YanomamiDomainSharedModule),
        typeof(AbpObjectExtendingModule),
        typeof(AbpDddApplicationContractsModule)
    )]
    public class YanomamiApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            YanomamiDtoExtensions.Configure();
        }
    }
}
