using Abp.Authorization;
using DZT.Authorization.Roles;
using DZT.Authorization.Users;

namespace DZT.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
