using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace theslowproject.Controllers
{
    public abstract class theslowprojectControllerBase: AbpController
    {
        protected theslowprojectControllerBase()
        {
            LocalizationSourceName = theslowprojectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
