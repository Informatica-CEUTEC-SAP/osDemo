using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OSDemo.Data;
using Volo.Abp.DependencyInjection;

namespace OSDemo.EntityFrameworkCore;

public class EntityFrameworkCoreOSDemoDbSchemaMigrator
    : IOSDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOSDemoDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the OSDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OSDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
