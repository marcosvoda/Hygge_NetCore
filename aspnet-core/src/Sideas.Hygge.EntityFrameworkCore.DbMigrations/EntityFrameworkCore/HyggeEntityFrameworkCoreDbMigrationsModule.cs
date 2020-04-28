using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Sideas.Hygge.EntityFrameworkCore
{
    [DependsOn(
        typeof(HyggeEntityFrameworkCoreModule)
        )]
    public class HyggeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HyggeMigrationsDbContext>();
        }
    }
}
