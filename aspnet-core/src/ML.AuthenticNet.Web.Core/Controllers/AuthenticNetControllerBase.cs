using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ML.AuthenticNet.Controllers
{
    public abstract class AuthenticNetControllerBase: AbpController
    {
        protected AuthenticNetControllerBase()
        {
            LocalizationSourceName = AuthenticNetConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
