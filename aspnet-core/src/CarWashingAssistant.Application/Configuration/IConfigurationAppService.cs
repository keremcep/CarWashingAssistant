using System.Threading.Tasks;
using CarWashingAssistant.Configuration.Dto;

namespace CarWashingAssistant.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
