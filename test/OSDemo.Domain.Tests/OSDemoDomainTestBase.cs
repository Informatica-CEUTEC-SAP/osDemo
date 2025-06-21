using Volo.Abp.Modularity;

namespace OSDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class OSDemoDomainTestBase<TStartupModule> : OSDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
