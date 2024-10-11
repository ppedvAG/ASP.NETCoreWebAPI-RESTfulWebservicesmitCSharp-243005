using System.ComponentModel.DataAnnotations;

namespace UserAuthWithJwtApi.Models
{
    public class LoginUserDto
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}