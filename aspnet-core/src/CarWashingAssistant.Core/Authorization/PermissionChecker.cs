using Abp.Authorization;
using CarWashingAssistant.Authorization.Roles;
using CarWashingAssistant.Authorization.Users;

namespace CarWashingAssistant.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
