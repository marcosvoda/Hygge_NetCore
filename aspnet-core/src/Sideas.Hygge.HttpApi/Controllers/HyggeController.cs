using Sideas.Hygge.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sideas.Hygge.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class HyggeController : AbpController
    {
        protected HyggeController()
        {
            LocalizationResource = typeof(HyggeResource);
        }
    }
}