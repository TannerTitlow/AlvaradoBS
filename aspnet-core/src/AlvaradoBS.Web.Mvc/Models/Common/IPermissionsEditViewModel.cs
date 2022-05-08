using System.Collections.Generic;
using AlvaradoBS.Roles.Dto;

namespace AlvaradoBS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}