using Abp.AutoMapper;
using CarWashingAssistant.Sessions.Dto;

namespace CarWashingAssistant.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
