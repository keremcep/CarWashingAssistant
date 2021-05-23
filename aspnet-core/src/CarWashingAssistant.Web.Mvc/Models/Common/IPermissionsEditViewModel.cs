using System.Collections.Generic;
using CarWashingAssistant.Roles.Dto;

namespace CarWashingAssistant.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}