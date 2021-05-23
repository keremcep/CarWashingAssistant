using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CarWashingAssistant.Web.Views
{
    public abstract class CarWashingAssistantRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CarWashingAssistantRazorPage()
        {
            LocalizationSourceName = CarWashingAssistantConsts.LocalizationSourceName;
        }
    }
}
