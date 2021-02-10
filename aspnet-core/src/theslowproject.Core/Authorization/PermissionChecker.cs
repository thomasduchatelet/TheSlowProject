using Abp.Authorization;
using theslowproject.Authorization.Roles;
using theslowproject.Authorization.Users;

namespace theslowproject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
