using Abp.Application.Services;
using AlvaradoBS.MultiTenancy.Dto;

namespace AlvaradoBS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

