using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Sideas.Hygge.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(HyggeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class HyggeConsoleApiClientModule : AbpModule
    {
        
    }
}
