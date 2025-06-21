using Volo.Abp.Modularity;

namespace OSDemo;

[DependsOn(
    typeof(OSDemoDomainModule),
    typeof(OSDemoTestBaseModule)
)]
public class OSDemoDomainTestModule : AbpModule
{

}
