using Abp.Application.Services;
using theslowproject.MultiTenancy.Dto;

namespace theslowproject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

