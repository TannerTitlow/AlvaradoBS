using System.Collections.Generic;
using AlvaradoBS.Roles.Dto;

namespace AlvaradoBS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
