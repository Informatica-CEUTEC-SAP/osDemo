using OSDemo.Localization;
using Volo.Abp.Application.Services;

namespace OSDemo;

/* Inherit your application services from this class.
 */
public abstract class OSDemoAppService : ApplicationService
{
    protected OSDemoAppService()
    {
        LocalizationResource = typeof(OSDemoResource);
    }
}
