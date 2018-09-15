using System.Threading.Tasks;
using Abp.Application.Services;
using ML.AuthenticNet.Authorization.Accounts.Dto;

namespace ML.AuthenticNet.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
