using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DZT.Controllers
{
    public abstract class DZTControllerBase: AbpController
    {
        protected DZTControllerBase()
        {
            LocalizationSourceName = DZTConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
