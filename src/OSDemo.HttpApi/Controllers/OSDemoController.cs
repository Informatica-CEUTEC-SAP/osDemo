using OSDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OSDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OSDemoController : AbpControllerBase
{
    protected OSDemoController()
    {
        LocalizationResource = typeof(OSDemoResource);
    }
}
