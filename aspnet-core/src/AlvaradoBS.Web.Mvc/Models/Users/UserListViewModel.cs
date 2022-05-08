using System.Collections.Generic;
using AlvaradoBS.Roles.Dto;

namespace AlvaradoBS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
