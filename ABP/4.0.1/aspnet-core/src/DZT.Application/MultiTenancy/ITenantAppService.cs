using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DZT.MultiTenancy.Dto;

namespace DZT.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
