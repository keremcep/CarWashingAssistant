using System.ComponentModel.DataAnnotations;

namespace CarWashingAssistant.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}