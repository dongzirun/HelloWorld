using System.Threading.Tasks;
using DZT.Configuration.Dto;

namespace DZT.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
