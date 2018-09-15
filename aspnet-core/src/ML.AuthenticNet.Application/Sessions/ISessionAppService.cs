using System.Threading.Tasks;
using Abp.Application.Services;
using ML.AuthenticNet.Sessions.Dto;

namespace ML.AuthenticNet.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
