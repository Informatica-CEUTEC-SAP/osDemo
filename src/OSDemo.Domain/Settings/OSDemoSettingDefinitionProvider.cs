using Volo.Abp.Settings;

namespace OSDemo.Settings;

public class OSDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OSDemoSettings.MySetting1));
    }
}
