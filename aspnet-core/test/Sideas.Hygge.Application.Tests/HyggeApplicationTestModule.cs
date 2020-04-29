using Volo.Abp.Modularity;

namespace Sideas.Hygge
{
    [DependsOn(
        typeof(HyggeApplicationModule),
        typeof(HyggeDomainTestModule)
        )]
    public class HyggeApplicationTestModule : AbpModule
    {

    }
}