using System.Threading.Tasks;
using AlvaradoBS.Configuration.Dto;

namespace AlvaradoBS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
