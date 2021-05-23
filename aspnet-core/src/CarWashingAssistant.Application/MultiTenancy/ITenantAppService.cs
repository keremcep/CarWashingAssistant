using Abp.Application.Services;
using CarWashingAssistant.MultiTenancy.Dto;

namespace CarWashingAssistant.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

