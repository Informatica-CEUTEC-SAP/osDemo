using System.Threading.Tasks;

namespace OSDemo.Data;

public interface IOSDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
