using System;
using System.Collections.Generic;
using System.Text;
using Sideas.Hygge.Localization;
using Volo.Abp.Application.Services;

namespace Sideas.Hygge
{
    /* Inherit your application services from this class.
     */
    public abstract class HyggeAppService : ApplicationService
    {
        protected HyggeAppService()
        {
            LocalizationResource = typeof(HyggeResource);
        }
    }
}
