using Yanomami.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Yanomami
{
    [DependsOn(
        typeof(YanomamiEntityFrameworkCoreTestModule)
        )]
    public class YanomamiDomainTestModule : AbpModule
    {

    }
}