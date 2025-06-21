using OSDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OSDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OSDemoEntityFrameworkCoreModule),
    typeof(OSDemoApplicationContractsModule)
)]
public class OSDemoDbMigratorModule : AbpModule
{
}
