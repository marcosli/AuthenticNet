using System.ComponentModel.DataAnnotations;

namespace ML.AuthenticNet.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}