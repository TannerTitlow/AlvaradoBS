using System.Threading.Tasks;
using Abp.Application.Services;
using AlvaradoBS.Authorization.Accounts.Dto;

namespace AlvaradoBS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
