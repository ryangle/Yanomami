using Yanomami.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Validation;

namespace Yanomami
{
    [DependsOn(
        typeof(AbpValidationModule)
        )]
    public class YanomamiDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<YanomamiDomainSharedModule>("Yanomami");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<YanomamiResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Yanomami");
            });
        }
    }
}
