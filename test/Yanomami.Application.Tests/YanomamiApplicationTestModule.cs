using Volo.Abp.Modularity;

namespace Yanomami
{
    [DependsOn(
        typeof(YanomamiApplicationModule),
        typeof(YanomamiDomainTestModule)
        )]
    public class YanomamiApplicationTestModule : AbpModule
    {

    }
}