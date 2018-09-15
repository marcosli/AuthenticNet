using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ML.AuthenticNet.Roles.Dto;
using ML.AuthenticNet.Users.Dto;

namespace ML.AuthenticNet.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
