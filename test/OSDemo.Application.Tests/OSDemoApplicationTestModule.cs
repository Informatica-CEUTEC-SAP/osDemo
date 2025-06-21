using Volo.Abp.Modularity;

namespace OSDemo;

[DependsOn(
    typeof(OSDemoApplicationModule),
    typeof(OSDemoDomainTestModule)
)]
public class OSDemoApplicationTestModule : AbpModule
{

}
