using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CarWashingAssistant.Controllers
{
    public abstract class CarWashingAssistantControllerBase: AbpController
    {
        protected CarWashingAssistantControllerBase()
        {
            LocalizationSourceName = CarWashingAssistantConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
