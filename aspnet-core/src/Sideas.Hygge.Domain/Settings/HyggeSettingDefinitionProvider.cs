using Volo.Abp.Settings;

namespace Sideas.Hygge.Settings
{
    public class HyggeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(HyggeSettings.MySetting1));
        }
    }
}
