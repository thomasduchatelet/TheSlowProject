using System.ComponentModel.DataAnnotations;

namespace theslowproject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}