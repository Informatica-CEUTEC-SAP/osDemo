using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OSDemo.Data;

/* This is used if database provider does't define
 * IOSDemoDbSchemaMigrator implementation.
 */
public class NullOSDemoDbSchemaMigrator : IOSDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
