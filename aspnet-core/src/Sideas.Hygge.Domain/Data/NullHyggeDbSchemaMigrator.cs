using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Sideas.Hygge.Data
{
    /* This is used if database provider does't define
     * IHyggeDbSchemaMigrator implementation.
     */
    public class NullHyggeDbSchemaMigrator : IHyggeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}