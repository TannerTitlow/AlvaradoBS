using Abp.Application.Services.Dto;

namespace AlvaradoBS.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

