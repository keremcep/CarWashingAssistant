using System.Collections.Generic;
using CarWashingAssistant.Roles.Dto;

namespace CarWashingAssistant.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
