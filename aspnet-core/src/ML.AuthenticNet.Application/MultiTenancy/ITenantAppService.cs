using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ML.AuthenticNet.MultiTenancy.Dto;

namespace ML.AuthenticNet.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
