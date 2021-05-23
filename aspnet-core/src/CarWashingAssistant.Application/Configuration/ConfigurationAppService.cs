using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CarWashingAssistant.Configuration.Dto;

namespace CarWashingAssistant.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CarWashingAssistantAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
