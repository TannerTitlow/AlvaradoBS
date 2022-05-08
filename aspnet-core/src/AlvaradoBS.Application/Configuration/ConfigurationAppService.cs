using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AlvaradoBS.Configuration.Dto;

namespace AlvaradoBS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AlvaradoBSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
