using Yanomami.ObjectExtending;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Domain;
using Volo.Abp.AutoMapper;
using Volo.Abp.Json;
using Volo.Abp.Data;
using Volo.Abp.Localization;
using Volo.Abp.Threading;
using Volo.Abp.Serialization;
using Volo.Abp.Timing;

namespace Yanomami
{
    [DependsOn(
        typeof(YanomamiDomainSharedModule),
        typeof(AbpDataModule),
        typeof(AbpLocalizationAbstractionsModule),
        typeof(AbpThreadingModule),
        typeof(AbpSerializationModule),
        typeof(AbpJsonModule),
        typeof(AbpTimingModule),
        typeof(AbpDddDomainModule),
        typeof(AbpAutoMapperModule)
        )]
    public class YanomamiDomainModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            YanomamiDomainObjectExtensions.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = false;
            });
        }
    }
}
