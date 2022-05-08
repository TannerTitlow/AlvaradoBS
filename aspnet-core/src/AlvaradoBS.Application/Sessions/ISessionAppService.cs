using System.Threading.Tasks;
using Abp.Application.Services;
using AlvaradoBS.Sessions.Dto;

namespace AlvaradoBS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
