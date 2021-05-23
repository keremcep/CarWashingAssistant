using System.Collections.Generic;
using CarWashingAssistant.Roles.Dto;

namespace CarWashingAssistant.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
