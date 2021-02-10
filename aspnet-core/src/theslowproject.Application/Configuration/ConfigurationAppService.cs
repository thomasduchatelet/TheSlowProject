using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using theslowproject.Configuration.Dto;

namespace theslowproject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : theslowprojectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
