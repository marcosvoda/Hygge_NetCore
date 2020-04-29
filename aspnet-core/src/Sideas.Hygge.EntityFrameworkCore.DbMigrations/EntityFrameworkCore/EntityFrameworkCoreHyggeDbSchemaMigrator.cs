using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sideas.Hygge.Data;
using Volo.Abp.DependencyInjection;

namespace Sideas.Hygge.EntityFrameworkCore
{
    public class EntityFrameworkCoreHyggeDbSchemaMigrator
        : IHyggeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreHyggeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the HyggeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<HyggeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}