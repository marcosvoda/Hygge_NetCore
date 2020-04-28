using Sideas.Hygge.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Sideas.Hygge.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(HyggeEntityFrameworkCoreDbMigrationsModule),
        typeof(HyggeApplicationContractsModule)
        )]
    public class HyggeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
