using Volo.Abp.Modularity;

namespace OSDemo;

public abstract class OSDemoApplicationTestBase<TStartupModule> : OSDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
