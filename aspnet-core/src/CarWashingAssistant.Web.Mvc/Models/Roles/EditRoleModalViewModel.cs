using Abp.AutoMapper;
using CarWashingAssistant.Roles.Dto;
using CarWashingAssistant.Web.Models.Common;

namespace CarWashingAssistant.Web.Models.Roles
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
