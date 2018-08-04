using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DZT.Configuration.Dto;

namespace DZT.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DZTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
