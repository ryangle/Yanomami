using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using Volo.Abp.ApiVersioning;
using Volo.Abp.DynamicProxy;
using Volo.Abp.Http.Modeling;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.AspNetCore;

namespace Yanomami.HttpApi
{
    [DependsOn(
        typeof(AbpAspNetCoreModule),
        typeof(AbpLocalizationModule),
        typeof(AbpApiVersioningAbstractionsModule)
        )]
    public class YanomamiHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            DynamicProxyIgnoreTypes.Add<ControllerBase>();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpApiDescriptionModelOptions>(options =>
            {
                options.IgnoredInterfaces.AddIfNotContains(typeof(IAsyncActionFilter));
                options.IgnoredInterfaces.AddIfNotContains(typeof(IFilterMetadata));
                options.IgnoredInterfaces.AddIfNotContains(typeof(IActionFilter));
            });
        }

    }
}
