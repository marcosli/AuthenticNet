using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ML.AuthenticNet.Configuration.Dto;

namespace ML.AuthenticNet.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AuthenticNetAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
