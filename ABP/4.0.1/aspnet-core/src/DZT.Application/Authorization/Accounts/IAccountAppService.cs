using System.Threading.Tasks;
using Abp.Application.Services;
using DZT.Authorization.Accounts.Dto;

namespace DZT.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
