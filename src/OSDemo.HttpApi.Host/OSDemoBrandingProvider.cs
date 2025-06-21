using Microsoft.Extensions.Localization;
using OSDemo.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OSDemo;

[Dependency(ReplaceServices = true)]
public class OSDemoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<OSDemoResource> _localizer;

    public OSDemoBrandingProvider(IStringLocalizer<OSDemoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
