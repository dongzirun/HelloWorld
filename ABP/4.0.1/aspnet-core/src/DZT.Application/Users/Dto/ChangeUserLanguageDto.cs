using System.ComponentModel.DataAnnotations;

namespace DZT.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}