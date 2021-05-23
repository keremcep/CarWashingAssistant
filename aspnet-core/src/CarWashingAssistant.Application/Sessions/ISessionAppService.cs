using System.Threading.Tasks;
using Abp.Application.Services;
using CarWashingAssistant.Sessions.Dto;

namespace CarWashingAssistant.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
