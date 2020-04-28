using Sideas.Hygge.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Sideas.Hygge
{
    [DependsOn(
        typeof(HyggeEntityFrameworkCoreTestModule)
        )]
    public class HyggeDomainTestModule : AbpModule
    {

    }
}