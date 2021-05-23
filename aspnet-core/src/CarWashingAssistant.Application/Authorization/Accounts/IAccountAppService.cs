using System.Threading.Tasks;
using Abp.Application.Services;
using CarWashingAssistant.Authorization.Accounts.Dto;

namespace CarWashingAssistant.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
