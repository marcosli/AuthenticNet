using System.Threading.Tasks;
using ML.AuthenticNet.Configuration.Dto;

namespace ML.AuthenticNet.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
