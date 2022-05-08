using Abp.Authorization;
using AlvaradoBS.Authorization.Roles;
using AlvaradoBS.Authorization.Users;

namespace AlvaradoBS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
