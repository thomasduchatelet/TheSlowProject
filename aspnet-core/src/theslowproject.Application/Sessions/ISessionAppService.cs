using System.Threading.Tasks;
using Abp.Application.Services;
using theslowproject.Sessions.Dto;

namespace theslowproject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
