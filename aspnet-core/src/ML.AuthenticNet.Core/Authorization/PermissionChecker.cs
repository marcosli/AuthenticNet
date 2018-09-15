using Abp.Authorization;
using ML.AuthenticNet.Authorization.Roles;
using ML.AuthenticNet.Authorization.Users;

namespace ML.AuthenticNet.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
