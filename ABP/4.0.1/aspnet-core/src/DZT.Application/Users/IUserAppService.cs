using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DZT.Roles.Dto;
using DZT.Users.Dto;

namespace DZT.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
