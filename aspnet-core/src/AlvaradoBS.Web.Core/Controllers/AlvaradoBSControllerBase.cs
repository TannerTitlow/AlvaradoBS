using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AlvaradoBS.Controllers
{
    public abstract class AlvaradoBSControllerBase: AbpController
    {
        protected AlvaradoBSControllerBase()
        {
            LocalizationSourceName = AlvaradoBSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
