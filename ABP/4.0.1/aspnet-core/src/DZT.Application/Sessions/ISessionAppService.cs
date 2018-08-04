using System.Threading.Tasks;
using Abp.Application.Services;
using DZT.Sessions.Dto;

namespace DZT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
