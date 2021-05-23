using Abp.AspNetCore.Mvc.ViewComponents;

namespace CarWashingAssistant.Web.Views
{
    public abstract class CarWashingAssistantViewComponent : AbpViewComponent
    {
        protected CarWashingAssistantViewComponent()
        {
            LocalizationSourceName = CarWashingAssistantConsts.LocalizationSourceName;
        }
    }
}
