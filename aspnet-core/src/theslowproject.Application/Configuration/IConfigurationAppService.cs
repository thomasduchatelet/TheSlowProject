using System.Threading.Tasks;
using theslowproject.Configuration.Dto;

namespace theslowproject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
