using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Yanomami
{
    [DependsOn(
        typeof(YanomamiApplicationContractsModule),
        typeof(AbpHttpClientModule)
    )]
    public class YanomamiHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(YanomamiApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
