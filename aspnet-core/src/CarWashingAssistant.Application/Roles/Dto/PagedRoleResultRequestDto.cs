using Abp.Application.Services.Dto;

namespace CarWashingAssistant.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

