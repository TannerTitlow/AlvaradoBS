using Abp.AutoMapper;
using AlvaradoBS.Roles.Dto;
using AlvaradoBS.Web.Models.Common;

namespace AlvaradoBS.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
