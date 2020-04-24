using Volo.Abp.Settings;

namespace Yanomami.Settings
{
    public class YanomamiSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(YanomamiSettings.MySetting1));
        }
    }
}
